using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Services
{
    public interface IVocabularyService
    {
        void AddVocabulary(Vocabulary vocabulary);
        Vocabulary GetVocabulary(int id);
        void UpdateVocabulary(Vocabulary vocabulary);
        void DeleteVocabulary(int id);
        List<Vocabulary> GetAllVocabularies();
    }
}
