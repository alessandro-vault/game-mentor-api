using LevelUpCenter.Home.Domain.Models;

namespace LevelUpCenter.Home.Domain.Repositories;

public interface IPublicationRepository
{
    Task<IEnumerable<Publication>> ListAsync();
    Task<Publication> FindByIdAsync(int tutorialId);
    Task<IEnumerable<Publication>> FindByUserIdAsync(int userId);
    Task AddAsync(Publication publication);
    void Update(Publication publication);
    void Remove(Publication publication);
}