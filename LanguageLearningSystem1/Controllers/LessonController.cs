using Microsoft.AspNetCore.Mvc;

public class LessonController : Controller
{
    public IActionResult Start()
    {
        return View(); 
    }

    public IActionResult StartLesson()
    {
        // Logika rozpoczęcia lekcji
        return View(); 
    }
}
