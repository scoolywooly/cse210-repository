using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() {
        _textbookSection = "Section 7.1";
        _problems = "1-25";
    }


    public string GetHomeworkList() {
        string homeworkList;

        homeworkList = base.GetSummary();
        homeworkList += $"\n{_textbookSection} -- {_problems}";

        return homeworkList;
    }

    public void setProblems(string problems) {
        _problems = problems;
    }

    
}