using System.Collections.Generic;
using System.Threading.Tasks;
using NoLaTengo.Dtos;
using NoLaTengo.Models;

namespace NoLaTengo.Services {

    public interface IBookService
    {
        Task<ServiceResponse<List<GetBookDto>>> GetAllBooks();
        Task<ServiceResponse<GetBookDto>> GetBookById(int id);
        Task<ServiceResponse<List<GetBookDto>>> AddBook(AddBookDto newBook);
        Task<ServiceResponse<GetBookDto>> UpdateBook(UpdateBookDto updatedBook);
        Task<ServiceResponse<List<GetBookDto>>> DeleteBook(int id);
    }
}