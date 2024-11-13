public class Profile
{
    public string Name { get; set; } = "David Rosskopf";
    public string Email { get; set; } = "DRosskopf@gmail.com";
    public string Phone { get; set; } = "801.810.9621";
    public string LinkedIn { get; set; } = "https://www.linkedin.com/in/drosskopf/";
    public string AboutMe { get; set; } = @"My interest in technology began at the age of 12, when my father introduced me to my first computer. This early
        exposure fueled my curiosity, and I quickly developed skills in troubleshooting, repairing, and enhancing
        computer systems. As a teenager, I was fortunate to gain hands-on experience when a neighbor hired me to build a
        website. With limited knowledge but a determination to learn, I successfully created two websites, earning my
        first $500 and solidifying my passion for web development.
        
        In the early stages of my career, I sought out small businesses in need of technical expertise, providing them
        with IT solutions and support. In my 20s, I joined a small software company as a tech support specialist. Eager
        to expand my knowledge, I immersed myself in learning the intricacies of software development. This dedication
        led to a promotion to Quality Assurance, where I honed my coding skills and deepened my understanding of
        software engineering.
        
        As my career progressed, I continued to build upon my technical expertise, embracing new technologies and
        developing innovative tools. Today, I am a Software Engineer, committed to delivering high-quality solutions and
        continuously refining my skill set in an ever-evolving industry.";

    public string[] Attributes { get; set; } = new[] { "Natural Leader", "Quick Learner", "Exterme Ownership", "Curious", "Trusted" };
}