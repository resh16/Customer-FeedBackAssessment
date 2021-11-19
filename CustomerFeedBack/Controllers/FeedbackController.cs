using CustomerFeedBack.Repository;
using CustomerFeedBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBack.Controllers
{
    public class FeedbackController : Controller
    {

        private readonly FeedbackRepository _feedbackRepository;

        public FeedbackController(FeedbackRepository feedbackRepository)
        {
            this._feedbackRepository = feedbackRepository;
        }


        [HttpPost]
        [Route("AddCandidate")]
        public void CreateCandidate([FromBody]CustomerFeedback customerFeedback)
        {
            try
            {
                _feedbackRepository.EnterFeedback(customerFeedback );
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
