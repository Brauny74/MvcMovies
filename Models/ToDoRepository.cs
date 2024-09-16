using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace L11.Models
{
	public class ToDo
	{
		public bool IsDone { get; set; }
		public string Title { get; set; }
		public int Priority { get; set; }

		public ToDo() 
		{
			IsDone = false;
			Title = string.Empty;
			Priority = 0;
		}

		public static ToDo CreateRandom()
		{
			Random r = new Random();
			ToDo td = new ToDo
			{
				IsDone = r.Next(0, 2) == 0,
				Title = $"To Do {r.Next(1, 1000)}",
				Priority = r.Next(1, 21)
			};
			return td;
		}
	}

	public interface IToDoRepository
	{
		public int GetCount();
		public int GetCountDone();
		public double GetAveragePriority();
		public ToDo GetByIndex(int i);
		public ToDo Random { get; }
	}

	public class ToDoRepository : IToDoRepository, IEnumerable
	{
		private readonly List<ToDo> _toDos;
		private readonly Random _r;

		public ToDoRepository()
		{
			_r = new Random();
			_toDos = new List<ToDo>();
			for (int i = 0; i < 50; i++)
				_toDos.Add(ToDo.CreateRandom());
		}

		public ToDo Random {
			get
			{
				return _toDos[_r.Next(_toDos.Count)];
			}
		}

		public double GetAveragePriority()
		{
			if (_toDos.Count == 0)
				return 0.0;

			return _toDos.Average(x => x.Priority);
		}

		public ToDo GetByIndex(int i)
		{
			return _toDos[i];
		}

		public int GetCount()
		{
			return _toDos.Count;
		}

		public int GetCountDone()
		{
			return _toDos.Count(x => x.IsDone);
		}

		public IEnumerator GetEnumerator()
		{
			return _toDos.GetEnumerator();
		}
	}
}
