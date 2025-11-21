using ClerklyLibrary.Models;
using Dapper;
using System.Data;


namespace ClerklyLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        private const string db = "Clerkly";

        public void AlterTransaction(TransactionModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateCompany(CompanyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters(); 
                p.Add("@CompanyName", model.CompanyName);
                p.Add("@CompanyAddress", model.CompanyAddress);
                p.Add("@CompanyEmail", model.CompanyEmail);
                p.Add("@CompanyTelephone", model.CompanyTelephone);
                p.Add("@FiscalDate", model.FiscalDate);
                p.Add("@CompanyUsername", model.CompanyUsername);
                p.Add("@CompanyPassword", model.CompanyPassword);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCompanyData_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }
        public void CreateInventoryItem(ItemModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ItemName", model.Name);
                p.Add("@UnitType", model.UnitType);
                p.Add("@OpeningStock", model.OpeningStock);
                
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCreateInventoryItem_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void CreateParty(PartyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PartyName", model.PartyName);
                p.Add("@PartyAddress", model.PartyAddress);
                p.Add("@PartyEmail", model.PartyEmail);
                p.Add("@PartyType", model.PartyType);
                p.Add("@StartingBalance", model.StartingBalance);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spParty_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public List<CompanyModel> Get_Company_All()
        {
            List<CompanyModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CompanyModel>("dbo.spCompany_GetAll").ToList();

                return output;
            }
        }

        public List<PartyModel> Get_Ledgers_All()
        {
            throw new NotImplementedException();
        }

        public List<TransactionModel> Get_Transactions_All()
        {
            throw new NotImplementedException();
        }

        public void SaveTransaction(TransactionModel model)
        {
            throw new NotImplementedException();
        }
        //public void CreatePerson(PersonModel model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@FirstName", model.FirstName);
        //        p.Add("@LastName", model.LastName);
        //        p.Add("@EmailAddress", model.EmailAddress);
        //        p.Add("@CellphoneNumber", model.CellphoneNumber);
        //        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

        //        model.Id = p.Get<int>("@id");

        //    }
        //}



        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The Prize information.</param>
        /// <returns>The prize info with the unique identifier attached  </returns>
        //public void CreatePrize(PrizeModel model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@PlaceNumber", model.PlaceNumber);
        //        p.Add("@PlaceName", model.PlaceName);
        //        p.Add("@PrizeAmount", model.PrizeAmount);
        //        p.Add("@PrizePercentage", model.PrizePercentage);
        //        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

        //        model.Id = p.Get<int>("@id");

        //    }
        //}

        //public void CreateTeam(TeamModel model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@TeamName", model.TeamName);
        //        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

        //        model.Id = p.Get<int>("@id");

        //        foreach (PersonModel tm in model.TeamMembers)
        //        {
        //            p = new DynamicParameters();
        //            p.Add("@TeamId", model.Id);
        //            p.Add("@PersonId", tm.Id);

        //            connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
        //        }

        //    }
   

        //public void CreateTournament(TournamentModel model)
        //{
            
            
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        //    {
        //        SaveTournament(connection, model);

        //        SaveTournamentEntries(connection, model);

        //        SaveTournamentPrizes(connection, model);

        //        SaveTournamentRounds(connection, model);

        //        TournamentLogic.UpdateTournamentResults(model);
               
                
        //    }
        //}
            
        //private void SaveTournament(IDbConnection connection,TournamentModel model)
        //{
        //    var p = new DynamicParameters();
        //    p.Add("@TournamentName", model.TournamentName);
        //    p.Add("@Entryfee", model.EntryFee);
        //    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //    connection.Execute("dbo.Tournaments_Insert", p, commandType: CommandType.StoredProcedure);

        //    model.Id = p.Get<int>("@id");
        //}

        //private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        //{
        //    foreach (PrizeModel pz in model.Prizes)
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@TournamentId", model.Id);
        //        p.Add("@PrizeId", pz.Id);
        //        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.TournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
        //    }
        //}

        //private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        //{
        //    foreach (TeamModel tm in model.EnteredTeams)
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@TournamentId", model.Id);
        //        p.Add("@TeamId", tm.Id);
        //        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.TournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);

        //    }
        //}
        //private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        //{
        //    //loop through rounds List<List<MatchupModel>> Rounds

        //    foreach (List<MatchupModel> round in model.Rounds)
        //    {
        //        //loo[ through the singular matchups
        //        foreach (MatchupModel matchup in round)
        //        {

        //            var p = new DynamicParameters();
        //            p.Add("@TournamentId", model.Id);
        //            p.Add("@MatchupRound",matchup.MatchupRound);
        //            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //            connection.Execute("dbo.Matchups_Insert", p, commandType: CommandType.StoredProcedure);

        //            matchup.Id = p.Get<int>("@id");

        //            foreach (MatchupEntryModel entry in matchup.Entries)
        //            {
        //                p = new DynamicParameters();
        //                p.Add("@MatchupId", matchup.Id);

        //                if (entry.ParentMatchup == null)
        //                {
        //                    p.Add("@ParentMatchupId",null);
        //                }
        //                else 
        //                {
        //                    p.Add("@ParentMatchupId", entry.ParentMatchup.Id);
        //                }

                        
        //                if (entry.TeamCompeting == null)
        //                {
        //                    p.Add("@TeamCompetingId", null);
        //                }
        //                else
        //                {
        //                    p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
        //                }
                       

                        
        //                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
        //            }
        //        }
        //    } 
        //}

        //public List<PersonModel> GetPerson_All()

        //{
        //   List<PersonModel> output;
        //   using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
        //   {
        //        output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
        //   }

        //   return output;
        //}

        //public List<TeamModel> GetTeam_All()
        //{
        //    List<TeamModel> output;
        //    using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
        //    {
        //        output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

        //        foreach (TeamModel team in output)
        //        {
        //            var p = new DynamicParameters();
        //            p.Add("@TeamId", team.Id);
        //            team.TeamMembers = connection.Query<PersonModel>("spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure ).ToList();
        //        }

        //        return output;
        //    }
        //}

        //public List<TournamentModel> GetTournament_All()
        //{
        //    List<TournamentModel> output;
        //    var p = new DynamicParameters();
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
        //    {
                

        //        output = connection.Query<TournamentModel>("dbo.Tournaments_GetAll").ToList();

        //        foreach(TournamentModel t in output)
        //        {
                    
        //            p = new DynamicParameters();
        //            p.Add("@TournamentId", t.Id);
                    

        //            //load prizes
        //            t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

        //            p = new DynamicParameters();
        //            p.Add("@TournamentId", t.Id);
        //            //load teams
        //            t.EnteredTeams = connection.Query<TeamModel>("dbo.Team_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                    
        //            foreach (TeamModel team in t.EnteredTeams)
        //            {
        //                p = new DynamicParameters();
        //                p.Add("@TeamId", team.Id);

        //                team.TeamMembers = connection.Query<PersonModel>("spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
        //            }

        //            p = new DynamicParameters();
        //            p.Add("@TournamentId", t.Id);
        //            //load rounds
        //            List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.Matchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
        //            foreach(MatchupModel m in matchups)
        //            {
        //                p = new DynamicParameters();
        //                p.Add("@MatchupId", m.Id);


        //                m.Entries = connection.Query<MatchupEntryModel>("spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();

        //                //populate each entry 
        //                //populate each matchup

        //                List<TeamModel> allTeams = GetTeam_All();
                        
        //                if(m.WinnerId > 0)
        //                {
        //                    m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
        //                }

        //                foreach(var me in m.Entries)
        //                {
        //                    if(me.TeamCompetingId > 0)
        //                    {
        //                        me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
        //                    }

        //                    if (me.ParentMatchupId > 0)
        //                    {
        //                        me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
        //                    }
        //                }
        //            }

        //            List<MatchupModel> currRow = new List<MatchupModel>();
        //            int currRound = 1;

        //            //list<list<MatchupModel>>
        //            foreach(MatchupModel m in matchups)
        //            {
        //                if(m.MatchupRound > currRound)
        //                {
        //                    t.Rounds.Add(currRow);
        //                    currRow = new List<MatchupModel>();
        //                    currRound += 1;
        //                }

        //                currRow.Add(m);
        //            }

        //            t.Rounds.Add(currRow);
        //        }
        //    }

        //    return output;

        //}

        //public void UpdateMatchup(MatchupModel model)
        //{
        //    //spMatchus_Update
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
        //    {
        //        var p = new DynamicParameters();
        //        if(model.Winner != null)
        //        {
        //            p.Add("@id", model.Id);
        //            p.Add("@WinnerId", model.Winner.Id);

        //            connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
        //        }
                
        //        foreach(MatchupEntryModel me in model.Entries)
        //        {
        //            if(me.TeamCompeting != null)
        //            {
        //                p = new DynamicParameters();
        //                p.Add("@id", me.Id);
        //                p.Add("@TeamCompetingId", me.TeamCompeting.Id);
        //                p.Add("Score", me.Score);

        //                connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
        //            }
        //        }
                    

        //    }
               

        //}

        //public void CompleteTournament(TournamentModel model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@id" , model.Id);
                

        //        connection.Execute("dbo.Tournaments_Complete", p, commandType: CommandType.StoredProcedure);

        //    }
        //}

        //public static void DeleteTournament(TournamentModel model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
        //    {
        //        var p = new DynamicParameters();
        //        p.Add("@id", model.Id);


        //        connection.Execute("dbo.spDeleteTournament", p, commandType: CommandType.StoredProcedure);

        //    }
        //}

    }
}
