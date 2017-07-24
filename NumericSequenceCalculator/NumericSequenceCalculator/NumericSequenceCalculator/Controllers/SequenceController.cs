using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NumericSequenceCalculator.Services;
using System.Collections;

namespace NumericSequenceCalculator.Controllers
{
    [RoutePrefix("api/sequences")]
    public class SequenceController : ApiController
    {
        private Calculator service;

        public SequenceController()
        {
            service = new Calculator();
        }

        [Route("{number:int}/all")]
        public IEnumerable<int> GetSequence(int number)
        {
            return service.Sequence(number);
        }

        [Route("{number:int}/even")]
        public IEnumerable<int> GetEvenSequence(int number)
        {
            return service.EvenSequence(number);
        }

        [Route("{number:int}/odd")]
        public IEnumerable<int> GetOddSequence(int number)
        {
            return service.OddSequence(number);
        }

        [Route("{number:int}/conditional")]
        public IEnumerable GetConditionalSequence(int number)
        {
            var result = service.ConditionalSequence(number);

            if (string.IsNullOrEmpty(result))
            {
                return service.Sequence(number);
            }

            return result;
        }

        [Route("{number:int}/fibonacci")]
        public IEnumerable<int> GetFibonacciSequence(int number)
        {
            return service.FibonacciSequence(number);
        }
    }
}