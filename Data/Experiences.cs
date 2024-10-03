public static class Experiences
{
    public static Experience PersonalProjects = new Experience(
        Name: "Personal Projects",
        Description: "I have a series of personal projects and trainings I do. All of my personal projects are written in Blazor. ",
        Company: "Dave's Awesome Code",
        Role: "Chief Everything",
        Points: [], 
        TechStack: new List<string> { ".Net Core", "Blazor", "Microsoft Sql", "Redis Cache" }
    );
    public static Experience Endorsements = new Experience(
        Name: "Ecclesiastical Endorsements",
        Description: "Endorsements project that allowed ecclesiastical leaders to endorse members.",
        Company: "The Church of Jesus Christ of Latter-day Saints",
        Role: "Team Lead",
        Points: [],
        TechStack: new List<string> { ".Net Core", "React", "Microsoft Sql", "Redis Cache" }
    );

    public static Experience Camping = new Experience(
        Name: "Recreational Property Management",
        Description: "Created a system to help manage reservations for the Church's 120 recreational propreties.",
        Company: "The Church of Jesus Christ of Latter-day Saints",
        Role: "Software Engineer => Team Lead",
        Points: [],
        TechStack: new List<string> { ".Net Core", "Angular", "Microsoft Sql", "Redis Cache" }
    );
    public static Experience SpaceManagement = new Experience(
        Name: "Space Management",
        Description: "Created a system to help manage the Church's 2.5 million sqft of office space. In this project we combined HR Data with floor plan data/imaging, allowing you to drag and drop employees to new locations on the floor plan.",
        Company: "The Church of Jesus Christ of Latter-day Saints",
        Role: "Software Engineer",
        Points: [],
        TechStack: new List<string> { ".Net Core", "AngularJs", "Microsoft Sql", "Redis Cache" }
    );
    public static Experience MeetinghousePlanning = new Experience(
        Name: "Meethinghouse Planning",
        Description: "This project combined data from multiple systems, to determine the capacity for meetinghouses. This inluded forecasting, and planning for future growth of the church.  Allowing strategic planning for new buildings.",
        Company: "The Church of Jesus Christ of Latter-day Saints",
        Role: "Quality Engineer => Software Engineer",
        Points: [],
        TechStack: new List<string> { ".Net", "MVC", "Oracle" }
    );
    public static Experience[] All = new[]
    {
        PersonalProjects,
        Endorsements,
        Camping,
        SpaceManagement,
        MeetinghousePlanning
    };
}