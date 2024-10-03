public record Experience(
    string Name, 
    string Description,
    string Company, 
    string Role,
    IEnumerable<string> Points,
    IEnumerable<string> TechStack
);