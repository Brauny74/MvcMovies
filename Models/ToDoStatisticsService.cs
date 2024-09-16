using System.Collections;

namespace L11.Models
{
	public class ToDoStatisticsService
	{
		private readonly IToDoRepository toDoRepository;

		public ToDoStatisticsService(IToDoRepository toDoRepository)
		{
			this.toDoRepository = toDoRepository;
		}

		public int GetCount()
		{ 
			return toDoRepository.GetCount();
		}

		public double GetAverage() 
		{
			return toDoRepository.GetAveragePriority();
		}

		public int GetCountDone()
		{ 
			return toDoRepository.GetCountDone();
		}

		public ToDo GetByIndex(int i)
		{ 
			return toDoRepository.GetByIndex(i);
		}
	}
}
