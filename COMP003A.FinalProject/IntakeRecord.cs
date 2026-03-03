using System;

namespace COMP003A.FinalProject;
//Class for Intake Records
public class IntakeRecord
{
    // 25 FIELDS----------------------------
    
    //String Fields
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;
    public string IntendedMajor;
    public string BackupMajor;
    public string AppliedTerm;
    public string HighSchoolName;
    public string Gender;
    public string EnrollmentStatus;
    public string StateResidency;

    //Numeric Fields
    public int Age;
    public int SATScore;
    public int ACTScore;
    public int GraduationYear;
    public int TransferableCredits;
    public int ApplicationID;
    public double GPA;
    public double FamilyIncome;
    public double ScholarshipAmount;
    

    //Selection based fields
    public string ApplicationType; //Transfer, Freshman
    public string AdmissionDecision; //computed from SAT/ACT and GPA
    
    //Bool Fields
    public bool IsVeteran;
    public bool HousingNeeded;
    public bool FirstGeneration;
    
    // Constructors
    public IntakeRecord(
        string firstName,
        string lastName,
        string applicationType,
        int age,
        int satScore,
        double gpa,
        bool firstGeneration)
    {
        ApplicationID = applicationID;
        LastName = lastName;
        FirstName = firstName;
        Age = age;
        GPA = gpa;
        SATScore = satScore;
        ACTScore = ACTScore;
        FirstGeneration = firstGeneration;
        ApplicationType = applicationType;

        // Using scores to derive AdmissionDecision
        if (GPA >= 3.75 && SATScore >= 1350)
        {
            AdmissionDecision = "Admission Likely";
        }
        else if (GPA >= 2.5 || SATScore >= 1200)
        {
            AdmissionDecision = "Under Review";
        }
        else
        {
            AdmissionDecision = "Denied";
        }
    }
    //method 1- App info display
    public void DisplayRecord()
    {
        Console.WriteLine($"ID: {ApplicationID} | {FirstName} {LastName} | GPA: {GPA} | Decision: {AdmissionDecision}");
    }
    //method 2-search menu
    public bool MatchesName(string searchName)
    {
        return LastName.ToLower() == searchName.ToLower()
            || FirstName.ToLower() == searchName.ToLower()
    }
}
