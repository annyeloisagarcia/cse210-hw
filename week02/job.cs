class Program
{
    static void Main(string[] args)
    {
        job myJob = new job();
        myJob._company = "Tech Solutions Inc.";
        myJob._jobTitle = "Software Engineer";
        myJob._startDate = "January 2020";
        myJob._endDate = "Present";
        myJob._jobDescription = "Developing and maintaining software applications.";

        myJob.Display();
    }
}