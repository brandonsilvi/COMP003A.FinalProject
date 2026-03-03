using System;

namespace COMP003A.FinalProject;

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
    
    //

}