using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Casino;

using Casino.Twentyaone;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Ali");

           
            const string casino = "Casino";
            Console.Write($"Welcome to this {casino}, Let's start with telling me your name: ");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadException();
                foreach( var exception in Exceptions)
                {
                    Console.Write(exception.Id + "|");
                    Console.Write(exception.ExceptionType + "|");
                    Console.Write(exception.ExceptionMessage + "|");
                    Console.Write(exception.TimeStamp + "|");
                    Console.WriteLine();
                }

                Console.ReadLine();
                return;

            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.Write("How much money did you bring today? ");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if(!validAnswer)Console.WriteLine("Please enter a amount of money in digits not decimal");
            }
           

            Console.Write($"Hello {playerName}, Would you like to join the game right now? ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" ||answer=="ya"|| answer == "y")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured, please contact the administrator");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                   
                }
                game -= player;
                Console.WriteLine("Thank you for playing!!");

            }

            Console.WriteLine("Feel free to go around the Casino, Bye for now.");
            Console.ReadLine();

        }
        private static void UpdateDbWithException (Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) values 
                                    (@ExceptinType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptinType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptinType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static List<ExceptionEntity> ReadException()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            string queryString = @"select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";
            List < ExceptionEntity > Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
        
    }
}