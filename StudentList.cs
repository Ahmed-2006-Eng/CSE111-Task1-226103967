//Name:Ahmed Yasser Sayed Ahmed Youssef Tabl
//Student id:226103967

namespace Cse111Task1
{
    public class StudentList
    {
        public Student First;
        public Student Last;
        public int Count;

        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }

            Count++;
        }

        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last.Next = newStudent;
                Last = newStudent;
            }

            Count++;
        }

        public bool Remove(int id)
        {
            if (First == null)
            {
                return false;
            }

            if (First.Id == id)
            {
                First = First.Next;
                Count--;

                if (First == null)
                {
                    Last = null;
                }

                return true;
            }

            Student current = First;

            while (current.Next != null && current.Next.Id != id)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return false;
            }

            if (current.Next == Last)
            {
                Last = current;
            }

            current.Next = current.Next.Next;
            Count--;

            return true;
        }

        public void Reverse()
        {
            Student oldFirst = First;
            Student previous = null;
            Student current = First;

            while (current != null)
            {
                Student next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            First = previous;
            Last = oldFirst;
        }

        public void Print()
        {
            Student current = First;
            bool firstStudent = true;

            while (current != null)
            {
                if (!firstStudent)
                {
                    System.Console.Write(" ");
                }

                System.Console.Write(current.Id);

                firstStudent = false;
                current = current.Next;
            }
        }
    }
}
