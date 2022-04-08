using System;
using System.Linq;
using System.Collections.Generic;
namespace exam
{

	class Student
	{	public string StudentName { get; set; }
		public string StudentID { get; set; }
		public string IdenficationCard { get; set; }
		public Int32 Mark { get; set; }
	}



	class SetStudnetDetail
	{

		static void Main(string[] args)
		{
			List<Student> studentList = new List<Student>() {
				new Student() { StudentID = "bcs21090002", StudentName = "jensen",IdenficationCard="011031013023", Mark = 90 } ,
				new Student() { StudentID = "bcs21090003", StudentName = "daniel", IdenficationCard="011031011223", Mark = 15 } ,
				new Student() { StudentID = "bcs21090004", StudentName = "howard", IdenficationCard="011031012323", Mark = 56 } ,
				new Student() { StudentID = "bcs21090005", StudentName = "john" , IdenficationCard="011031015623",Mark = 34 } ,
				new Student() { StudentID = "bcs21090006", StudentName = "caleb" ,IdenficationCard="011031013423", Mark = 19 }
			};





			void DisplayAllStudentDetails(List<Student> studenList)
			{
				var orderByResult = from s in studentList
									orderby s.StudentName, s.StudentID, s.IdenficationCard
									select s;
				foreach (var std in orderByResult)

					Console.WriteLine(std.StudentName + "\t\t" + std.StudentID + "\t\t" + std.IdenficationCard);


			}

			void DisplayAllStudentRanking(List<Student> students)
			{
				studentList.Sort((m1, m2) => m2.Mark.CompareTo(m1.Mark));

				foreach (Student std in studentList)
				{
					Console.WriteLine(std.Mark + "\t\t" + std.StudentName + "\t\t" +std.StudentID);
				}
				Console.Read();
			}


			Console.WriteLine("StudentName:\tStudentID:\tIdenficationCard");
			DisplayAllStudentDetails(studentList);
			Console.WriteLine("Marks:\t\tStudentName:\tStudentID:");
			DisplayAllStudentRanking(studentList);
			Console.Read();
		}

		
	}
}