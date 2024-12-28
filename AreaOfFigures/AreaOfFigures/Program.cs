namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool userChoiceRepeatBool = true;
            string userChoiceRepeatString;
            string userChoiceFigure;
            string userInput;
            do
            {
                Console.WriteLine("Do you want to calculate and area of a: 1 - Circle, 2 - Triangle");
                userChoiceFigure = Console.ReadLine();
                if(int.TryParse(userChoiceFigure, out int userChoiceInt))
                {
                    if(userChoiceInt == 1)
                    {
                        Console.WriteLine("Enter the radius of the circle: ");
                        userInput = Console.ReadLine();
                        if(int.TryParse(userInput, out int radius))
                        {
                            if (radius > 0)
                            {
                                double circleArea = radius * radius * Math.PI;
                                Console.WriteLine($"The are of a given circle is equal to {circleArea}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input: Circle's radius cannot be equal to zero or negative!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid circle radius provided!");
                        }
                    }
                    else if (userChoiceInt == 2)
                    {
                        int triangle1, triangle2, triangle3;
                        Console.WriteLine("Enter the length of the first side of the triangle: ");
                        userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out triangle1))
                        {
                            if (triangle1 > 0)
                            {
                                Console.WriteLine("Enter the length of the second side of the triangle: ");
                                userInput = Console.ReadLine();
                                if (int.TryParse(userInput, out triangle2))
                                {
                                    if (triangle2 > 0)
                                    {
                                        Console.WriteLine("Enter the lenght of the third side of the triangle: ");
                                        userInput = Console.ReadLine();
                                        if (int.TryParse(userInput, out triangle3))
                                        {
                                            if (triangle3 > 0)
                                            {
                                                if(triangle1 < triangle2 +  triangle3 || triangle2 < + triangle1 + triangle3 || triangle3 < triangle1 + triangle2)
                                                {
                                                    double triangleCircumferenceHalf = (triangle1 + triangle2 + triangle3) / 2.0;
                                                    double triangleArea = Math.Sqrt((triangleCircumferenceHalf) * (triangleCircumferenceHalf - triangle1) * (triangleCircumferenceHalf - triangle2) * (triangleCircumferenceHalf - triangle3));
                                                    Console.WriteLine($"The area of the given triangle is equal to {triangleArea}");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input! Provided side lengths cannot construct a triangle!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid input: Lenght of the side cannot be negative or equal to zero!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input: Lenght of the side cannot be negative or equal to zero!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input: Lenght of the side cannot be negative or equal to zero!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Only numbers 1 and 2 are accepted!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("Do you want to calculate the area of another figure? Y/N");
                userChoiceRepeatString = Console.ReadLine();
                while(string.IsNullOrEmpty(userChoiceRepeatString) || !(new[] {"Y", "y","N","n"}.Contains(userChoiceRepeatString)))
                {
                   Console.WriteLine("Invalid input!");
                   userChoiceRepeatString = Console.ReadLine();
                }
                if(userChoiceRepeatString.Equals("N")  || userChoiceRepeatString.Equals("n"))
                {
                    userChoiceRepeatBool = false;
                }
                else if(userChoiceRepeatString.Equals("Y") || userChoiceRepeatString.Equals("y"))
                {
                    userChoiceRepeatBool = true;
                }
                Console.Clear();
            } while (userChoiceRepeatBool);
        }
    }
}
