using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NoLaTengo.Data;
using NoLaTengo.Dtos;
using NoLaTengo.Models;

namespace NoLaTengo.Services
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BookService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetBookDto>>> AddBook(AddBookDto newBook)
        {
            ServiceResponse<List<GetBookDto>> response = new ServiceResponse<List<GetBookDto>>();

            Book dbBook = _mapper.Map<Book>(newBook);

            await _context.Books.AddAsync(dbBook);
            await _context.SaveChangesAsync();

            response.Data = _context.Books.Select(b => _mapper.Map<GetBookDto>(b)).ToList();

            return response;
        }

        public async Task<ServiceResponse<List<GetBookDto>>> DeleteBook(int id)
        {
            ServiceResponse<List<GetBookDto>> response = new ServiceResponse<List<GetBookDto>>();

            try
            {
                Book dbBook = await _context.Books.FirstAsync(b => b.Id == id);
                _context.Books.Remove(dbBook);
                await _context.SaveChangesAsync();

                response.Data = _context.Books.Select(b => _mapper.Map<GetBookDto>(b)).ToList();
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.Sucess = false;
            }

            return response;
        }

        public async Task<ServiceResponse<List<GetBookDto>>> GetAllBooks()
        {
            ServiceResponse<List<GetBookDto>> response = new ServiceResponse<List<GetBookDto>>();

            List<Book> dbBooks = await _context.Books.ToListAsync();

            response.Data = dbBooks.Select(b => _mapper.Map<GetBookDto>(b)).ToList();

            return response;
        }

        public async Task<ServiceResponse<GetBookDto>> GetBookById(int id)
        {
            ServiceResponse<GetBookDto> response = new ServiceResponse<GetBookDto>();

            Book dbBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

            response.Data = _mapper.Map<GetBookDto>(dbBook);

            return response;
        }

        public async Task<ServiceResponse<GetBookDto>> UpdateBook(UpdateBookDto updatedBook)
        {
            ServiceResponse<GetBookDto> response = new ServiceResponse<GetBookDto>();

            try
            {
                Book dbBook = await _context.Books.FirstOrDefaultAsync(b => b.Id == updatedBook.Id);

                dbBook.Description = updatedBook.Description;
                dbBook.ElementCategory = updatedBook.ElementCategory;
                dbBook.ElementName = updatedBook.ElementName;
                dbBook.Finished = updatedBook.Finished;
                dbBook.PagesNumber = updatedBook.PagesNumber;
                dbBook.PublishedDate = updatedBook.PublishedDate;
                dbBook.Publisher = updatedBook.Publisher;

                _context.Books.Update(dbBook);
                await _context.SaveChangesAsync();

                response.Data = _mapper.Map<GetBookDto>(dbBook);
            }

            catch (Exception ex)
            {
                response.Sucess = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}