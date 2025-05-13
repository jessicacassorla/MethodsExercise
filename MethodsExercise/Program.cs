namespace MethodsExercise
{
    public class Program
    {
        public static void MethodStory()
        {
            Console.WriteLine("Howdy, partner! What'd you call yerself?");
            string name = Console.ReadLine();
            Console.WriteLine($"Well howdy, {name}! Nice of you to drop by. Where ya comin' from?");
            string hometown = Console.ReadLine();
            Console.WriteLine($"Say, {name}, I've never been to {hometown}, but I reckon it ain't too far from here.\nSay, I could go for some grub. What's yer favorite food? I'll treat ya to lunch!");
            string favFood = Console.ReadLine();
            Console.WriteLine($"You like {favFood}? Well I'll be darned {name}, that's my favorite, too!\nOne last thing {name}...what's yer mom's name?");
            string momName = Console.ReadLine();

            Console.WriteLine($"{name}, I want to make a story for you.\nOnce upon a time, a lone traveller named {name} trekked all the way from {hometown}. By the time they got here, they were so hungry, so they went to the saloon and ordered some {favFood}. By the time they made it to their living quarters for the night, all they could think about was their momma, {momName}, so they wrote her a letter after a long day travelled.");
        }
        static void Main(string[] args)
        {
            MethodStory();
        }
    }
}
