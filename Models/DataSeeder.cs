using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BuffteksWebsite.Models
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BuffteksWebsiteContext(serviceProvider.GetRequiredService<DbContextOptions<BuffteksWebsiteContext>>()))
            {

                // CLIENTS
                if (context.Clients.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var clients = new List<Client>
                {
                    new Client { FirstName="James", LastName="Mackleroy", CompanyName="Apple", Email="jmackleroy@apple.com", Phone="806-443-9485" },
                    new Client { FirstName="Kirstie", LastName="Wool", CompanyName="Google", Email="kwool@gmail.com", Phone="806-345-2945" },
                    new Client { FirstName="Trevor", LastName="Micheals", CompanyName="Amarillo Bolt Company", Email="tmicheals@amarillobolt.com", Phone="806-495-2485" }
                };
                context.AddRange(clients);
                context.SaveChanges();


                // CLIENTS
                if (context.Members.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var members = new List<Member>
                {
                    new Member { FirstName="Charles", LastName="Coufal", Major="CIS", Email="ccoufal@buffs.wtamu.edu", Phone="806-367-3979" },
                    new Member { FirstName="Aaron", LastName="Herbert", Major="CIS", Email="aherbert@buffs.wtamu.edu", Phone="806-395-9433" },
                    new Member { FirstName="Matt", LastName="Webb", Major="CIS", Email="mwebb@buffs.wtamu.edu", Phone="806-748-3958" },
                    new Member { FirstName="Laith", LastName="Junior", Major="CIS", Email="ljunior@buffs.wtamu.edu", Phone="806-395-4954" },
                    new Member { FirstName="Alex", LastName="Roder", Major="CIS", Email="aroder@buffs.wtamu.edu", Phone="806-945-3984" },
                    new Member { FirstName="Quan", LastName="Nguyen", Major="CIS", Email="qnguyen@buffs.wtamu.edu", Phone="806-945-3943" },
                    new Member { FirstName="Catherine", LastName="McGovern", Major="CIS", Email="cmcgovern@buffs.wtamu.edu", Phone="806-395-3854" },
                    new Member { FirstName="Todd", LastName="Kile", Major="CIS", Email="tkile@buffs.wtamu.edu", Phone="806-945-4859" },
                    new Member { FirstName="Amy", LastName="Sayso", Major="CIS", Email="asayso@buffs.wtamu.edu", Phone="806-495-8584" },
                    new Member { FirstName="Cory", LastName="Williams", Major="CIS", Email="cwilliams@buffs.wtamu.edu", Phone="806-495-4856" }
                };
                context.AddRange(members);
                context.SaveChanges();

                // PROJECTS
                if (context.Projects.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                var projects = new List<Project>
                {
                    new Project { ProjectName="Google 2.0", ProjectDescription="Making Google twice as good." },
                    new Project { ProjectName="The New Website", ProjectDescription="Creating a new website." },
                    new Project { ProjectName="Update Payment System", ProjectDescription="Updating the company's online payment system." }
                };
                context.AddRange(projects);
                context.SaveChanges();

                //PROJECT ROSTER BRIDGE TABLE - THERE MUST BE PROJECTS AND PARTICIPANTS MADE FIRST
                if (context.ProjectRoster.Any())
                {
                    //leave, there is already data in the database
                    return; 
                }

                

                //quickly grab the recent records added to the DB to get the IDs
                var projectsFromDb = context.Projects.ToList();
                var clientsFromDb = context.Clients.ToList();
                var membersFromDb = context.Members.ToList();

                var projectroster = new List<ProjectRoster>
                {
                    //take the first project from above, the first client from above, and the first three students from above.
                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = clientsFromDb.ElementAt(0).ID.ToString(),
                                        ProjectParticipant = clientsFromDb.ElementAt(0) },

                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = membersFromDb.ElementAt(0).ID.ToString(),
                                        ProjectParticipant = membersFromDb.ElementAt(0) },

                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = membersFromDb.ElementAt(1).ID.ToString(),
                                        ProjectParticipant = membersFromDb.ElementAt(1) },

                    new ProjectRoster { ProjectID = projectsFromDb.ElementAt(0).ID.ToString(), 
                                        Project = projectsFromDb.ElementAt(0), 
                                        ProjectParticipantID = membersFromDb.ElementAt(2).ID.ToString(),
                                        ProjectParticipant = membersFromDb.ElementAt(2) },                                        
                };
                context.AddRange(projectroster);
                context.SaveChanges();                

            }
        }
    }
}