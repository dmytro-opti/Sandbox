using System;

namespace Sandbox1.People
{
    public class Recruiter : Person
    {
        public int RecruitmentSkill { get; set; } 
        public int SalaryMultiplier => CalculateSalaryMultiplier();

        public Recruiter(string name, int priority, int monthlySalary, int budget, int recruitmentSkill)
            : base()
        {
            Id = Guid.NewGuid();
            Name = name;
            Priority = priority;
            MonthlySalary = monthlySalary;
            Budget = budget;
            RecruitmentSkill = recruitmentSkill;
        }

        private int CalculateSalaryMultiplier()
        {
            return RecruitmentSkill switch
            {
                <= 5 => 1,
                <= 10 => 2,
                _ => 3
            };
        }

        public void Recruit(Warrior warrior)
        {
            int salaryCost = MonthlySalary * SalaryMultiplier;
            Console.WriteLine($"{Name} найняв воїна: {warrior.Name}, вартість найму: {salaryCost}");
            warrior.Level += RecruitmentSkill; 
        }
    }
}
