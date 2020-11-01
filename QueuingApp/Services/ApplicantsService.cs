using QueuingApp.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueuingApp.Services
{
    public class ApplicantsService
    {
        private readonly IMongoCollection<Applicants> applicants;

        public ApplicantsService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("ServerName"));
            IMongoDatabase database = client.GetDatabase(config.GetConnectionString("DatabaseName"));
            applicants = database.GetCollection<Applicants>("Applicants");
        }

        public List<Applicants> Get()
        {
            return applicants.Find(applicant => true).ToList();
        }

        public Applicants Get(string Id)
        {
            return applicants.Find(applicant => applicant.objectId == Id).FirstOrDefault();
        }

        public Applicants Create(Applicants applicant)
        {
            applicants.InsertOne(applicant);
            return applicant;
        }

        public void Update(string Id, Applicants applicantIn)
        {
            applicants.ReplaceOne(applicant => applicant.objectId == Id, applicantIn);
        }

        public void Remove(Applicants applicantIn)
        {
            applicants.DeleteOne(applicant => applicant.objectId == applicantIn.objectId);
        }

        public void Remove(string Id)
        {
            applicants.DeleteOne(applicant => applicant.objectId == Id);
        }
    }
}
