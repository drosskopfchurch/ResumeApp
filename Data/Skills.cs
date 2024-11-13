public static class Skills
{
    public static Skill CSharp = new Skill(
        Code: "C#",
        Name: "C#",
        Description: "",
        Rating: 4,
        Started: new DateTime(2006, 1, 1),
        Ended: null
    );
    public static Skill DotNetCore = new Skill(
        Code: ".Net Core",
        Name: ".Net Core",
        Description: "",
        Rating: 4,
        Started: new DateTime(2016, 9, 1),
        Ended: null
    );
    public static Skill EFCore = new Skill(
        Code: "Ef Core",
        Name: "Entity Framework",
        Description: "I have been doing Code First migrations with all of my projects since 2017. I would consider myself an expert in Entity Framework. ",
        Rating: 5,
        Started: new DateTime(2016, 9, 1),
        Ended: null
    );
    public static Skill React = new Skill(
        Code: "React",
        Name: "React JS",
        Description: "I have been using React since 2019, I have built a couple applications with it. I am big fan of using Context Api for state management.",
        Rating: 4,
        Started: new DateTime(2019, 3, 1),
        Ended: null
    );
    public static Skill Angular = new Skill(
        Code: "Angular",
        Name: "Angular",
        Description: "I worked on Angular from version 2-6. I am not current on the language, it would take me a little bit to catch up.",
        Rating: 3,
        Started: new DateTime(2016, 5, 1),
        Ended: new DateTime(2019, 10, 1)
    );
    public static Skill MicrosoftSql = new Skill(
        Code: "Microsoft Sql",
        Name: "Microsoft Sql",
        Description: "I can write pretty complex SQL queries.  I have a really understanding of schema, structure, indexes, functions, stored procedures, triggers. ",
        Rating: 4,
        Started: new DateTime(2017, 5, 1),
        Ended: null
    );
    public static Skill Oracle = new Skill(
        Code: "Oracle",
        Name: "Oracle",
        Description: "I am very familiar with SQL, I used Oracle for a couple of years. I can write complex queries, functions, stored procedures, triggers, but it has been a while, so I may be fuzzy on the syntax.",
        Rating: 3,
        Started: new DateTime(2010, 5, 1),
        Ended: new DateTime(2013, 5, 1)
    );
    public static Skill Blazor = new Skill(
        Code: "Blazor",
        Name: "Blazor",
        Description: "I have done a couple small personal projects using Blazor.  I am familiar with the structure, components, and lifecycle. I haven't used it in my day job yet.",
        Rating: 4,
        Started: new DateTime(2020, 5, 1),
        Ended: null
    );
    public static Skill Redis = new Skill(
        Code: "Redis",
        Name: "Redis",
        Description: "I have setup a redis server, and I understand caching basics.",
        Rating: 3,
        Started: new DateTime(2017, 5, 1),
        Ended: null
    );
    public static Skill Javascript = new Skill(
        Code: "Javascript",
        Name: "Javascript",
        Description: "I am pretty familiar with Javascript, I have been using it pretty regularly for a long time.",
        Rating: 5,
        Started: new DateTime(2015, 5, 1),
        Ended: null
    );
    public static Skill CSS = new Skill(
        Code: "CSS",
        Name: "Custom Style Sheets",
        Description: "I have been using CSS for a while but I still need to google how to apply the right when I am trying to do anything complex.  I use straight vanilla or component CSS, I having used any preprocessors.",
        Rating: 3,
        Started: new DateTime(2015, 5, 1),
        Ended: null
    );
    public static Skill YMLPipelines = new Skill(
        Code: "YML",
        Name: "YML Pipelines",
        Description: "I have been using YML pipelines for a while now with Azure Dev Ops, I am pretty comfortable with them and creating templates.",
        Rating: 4,
        Started: new DateTime(2020, 5, 1),
        Ended: null
    );
    public static Skill AzureDevops = new Skill(
        Code: "DevOps",
        Name: "Azure DevOps",
        Description: "I am familiar with Azure Devops, creating boards, adding tests, managing code, etc..",
        Rating: 4,
        Started: new DateTime(2018, 5, 1),
        Ended: null
    );
    public static Skill Github = new Skill(
        Code: "Github",
        Name: "Github",
        Description: "I use Github, but not quite an expert on all the features and capabilities.",
        Rating: 3,
        Started: new DateTime(2020, 5, 1),
        Ended: null
    );
    public static Skill Git = new Skill(
        Code: "Git",
        Name: "Git",
        Description: "I have been using Git for a while, I fairly comfortable with it. I am very familiar with gitflow",
        Rating: 4,
        Started: new DateTime(2015, 5, 1),
        Ended: null
    );
    public static Skill WebDriver = new Skill(
        Code: "WebDriver",
        Name: "WebDriver",
        Description: "I have beeing using webdriver for years, I am very comfortable with it.",
        Rating: 4,
        Started: new DateTime(2015, 5, 1),
        Ended: null
    );
    public static Skill[] All()
    {
        return new[]
        {
        CSharp,
        DotNetCore,
        EFCore,
        React,
        Angular,
        MicrosoftSql,
        Oracle,
        Blazor,
        Redis,
        Javascript,
        CSS,
        YMLPipelines,
        AzureDevops,
        Github,
        Git,
        WebDriver
    };
    }

}