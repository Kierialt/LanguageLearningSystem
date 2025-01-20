using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Services
{
    public interface ILessonService
    {
        void AddLesson(Lesson lesson);
        Lesson GetLesson(int id);
        void UpdateLesson(Lesson lesson);
        void DeleteLesson(int id);
        List<Lesson> GetAllLessons();
    }
}
