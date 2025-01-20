using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Services
{
    public class VocabularyService : IVocabularyService
    {
        private readonly List<Vocabulary> _vocabularies = new();

        public void AddVocabulary(Vocabulary vocabulary) => _vocabularies.Add(vocabulary);

        public Vocabulary GetVocabulary(int id) => _vocabularies.FirstOrDefault(v => v.Id == id);

        public void UpdateVocabulary(Vocabulary vocabulary)
        {
            var existing = GetVocabulary(vocabulary.Id);
            if (existing != null)
            {
                existing.Word = vocabulary.Word;
                existing.Translation = vocabulary.Translation;
            }
        }

        public void DeleteVocabulary(int id) => _vocabularies.RemoveAll(v => v.Id == id);

        public List<Vocabulary> GetAllVocabularies() => _vocabularies;
    }
}
