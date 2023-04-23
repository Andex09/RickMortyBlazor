using RickMortyBlazor.Models;

namespace RickMortyBlazor.Client.Services.Interfaces
{
    public interface IRickMortyApi
    {
        Task<GeneralResponse<Character>> GetAllChararters(PaginationParameters parameters);
        Task<Character> GetChararter(int id);
        Task<GeneralResponse<Character>> GetSearchChararters(PaginationParameters parameters, Filter query);
        Task<Episode> GetEpisode(int id);
    }
}
