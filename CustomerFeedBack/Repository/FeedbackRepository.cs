using CustomerFeedBack.ViewModel;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBack.Repository
{
    public class FeedbackRepository
    {
        private readonly IConfiguration _configuration;
        public FeedbackRepository(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        
        // Create Feedback

        public void EnterFeedback(CustomerFeedback customerFeedback)
        {
            using IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            string sp = "EnterFeedback";

            DynamicParameters parameters = new();

            parameters.Add("Title", customerFeedback.Title);
            parameters.Add("First", customerFeedback.First);
            parameters.Add("Initial", customerFeedback.Initial);
            parameters.Add("AddressLine", customerFeedback.AddressLine);
            parameters.Add("AddressLine2", customerFeedback.AddressLine2);
            parameters.Add("City", customerFeedback.City);
            parameters.Add("Region", customerFeedback.Region);
            parameters.Add("PostalCode", customerFeedback.PostalCode);
            parameters.Add("Country", customerFeedback.Country);
            parameters.Add("ProductId", customerFeedback.ProductId);
            parameters.Add("Rating", customerFeedback.Rating);
            parameters.Add("Comments", customerFeedback.Comments);
            parameters.Add("Reason", customerFeedback.Reason);
            parameters.Add("FileUpload", customerFeedback.FileUpload);

            SqlMapper.Execute(dbConnection, sp, commandType: CommandType.StoredProcedure, param: parameters);



        }



    }




}

