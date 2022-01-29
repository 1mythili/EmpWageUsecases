using FellowshipUsecase;

Console.WriteLine("Hello, World!");
//UC1_EmployeeAttendance.GetAttendance();
//UC2_EmpWage.EmpWage();
//UC3_PartTimeEmpWage.PartTimeEmpWage();
//UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
//UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
//UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
//UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
//UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("TCS",20,2,10);

#region UC9
UC_9EmpWageBuilderObject dMart = new UC_9EmpWageBuilderObject ("DMart", 20, 2, 10);
UC_9EmpWageBuilderObject reliance = new UC_9EmpWageBuilderObject("Reliance", 10, 4, 20);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());
#endregion  UC9Ending

//#region UC10
//EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
//empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();
//#endregion