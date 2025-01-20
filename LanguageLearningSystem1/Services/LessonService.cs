using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Services
{
    public class LessonService : ILessonService
    {
        private readonly List<Lesson> _lessons = new();

        public void AddLesson(Lesson lesson) => _lessons.Add(lesson);

        public Lesson GetLesson(int id) => _lessons.FirstOrDefault(l => l.Id == id);

        public void UpdateLesson(Lesson lesson)
        {
            var existing = GetLesson(lesson.Id);
            if (existing != null)
            {
                existing.Title = lesson.Title;
                existing.Description = lesson.Description;
            }
        }

        public void DeleteLesson(int id) => _lessons.RemoveAll(l => l.Id == id);

        public List<Lesson> GetAllLessons() => _lessons;
    }
}
