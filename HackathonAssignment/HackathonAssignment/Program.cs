namespace HackathonAssignment
{

    class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
    class Notes
    {
        List<Note> notes = new List<Note>();
        static int c = 1;
        public void CreateNote()
        {

            Console.WriteLine("Enter title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter description");
            string description = Console.ReadLine();
            int id = c++;
            Console.WriteLine(id);
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            notes.Add(new Note() { Title = title, Description = description, Id = id, Date = date });
        }
        public void ViewNotesId()
        {
            Console.WriteLine("Enter details");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Note note in notes)
            {
                if (note.Id == id)
                {
                    Console.WriteLine("id\ttitle\tdescription\t\t\tdate");
                    Console.WriteLine($"{note.Id}\t{note.Title}\t\t{note.Description}\t{note.Date}");

                }
            }
        }
        public void ViewAllNotes()
        {
            foreach (Note note in notes)
            {
                Console.WriteLine("id\ttitle\t\tdescription\t\t\tdate");
                Console.WriteLine($"{note.Id}\t{note.Title}\t{note.Description}\t{note.Date}");
               
            }
            Console.WriteLine($"TotalNotes:{ notes.Count}");
        }
        public void UpdateNote()
        {
            Console.WriteLine("Enter details");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Note note in notes)
            {
                if (note.Id == id)
                {
                    Console.WriteLine("Enter the update title");
                    note.Title = Console.ReadLine();
                    Console.WriteLine("Enter the update description");
                    note.Description = Console.ReadLine();
                }
            }
        }
        public bool DeleteNote()
        {
            Console.WriteLine("Enter details");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Note note in notes)
            {
                if (note.Id == id)
                {
                    notes.Remove(note);
                    return true;
                }
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Notes obj = new Notes ();
            while (true)
            {
                Console.WriteLine("1  Create Note");
                Console.WriteLine("2  View NoteId");
                Console.WriteLine("3  ViewallNotes");
                Console.WriteLine("4  Update Notes");
                Console.WriteLine("5  Delete Note");
                try
                {
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {  
                        case 1:
                        {
                            obj.CreateNote();
                            break;
                        }
                        case 2:
                        {
                            obj.ViewNotesId();
                            break;
                        }
                        case 3:
                        {
                            obj.ViewAllNotes();
                            break;
                        }
                        case 4:
                        {
                            obj.UpdateNote();
                            break;
                        }
                        case 5:
                        {
                            if (obj.DeleteNote())
                            {
                                Console.WriteLine(" Deleted Successfully ");
                            }
                            else
                            {
                                Console.WriteLine("Id is not found");
                            }
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Enter a valid option");
                            break;
                        }
                    }
                }
                catch(FormatException)
                {
                Console.WriteLine("Enter only Numbers From 1 to 5");
                }
            }
        }
    }
}