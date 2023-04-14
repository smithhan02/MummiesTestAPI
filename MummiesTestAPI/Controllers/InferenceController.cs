using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.ML.OnnxRuntime;
using MummiesTestAPI.Data;
namespace MummiesTestAPI.Controllers
{
    [ApiController]
    [Route("/score")]
        public class APIController : ControllerBase
        {
            private InferenceSession _session;

            public APIController(InferenceSession session)
            {
                _session = session;
            }

            [HttpPost]
            public ActionResult Score(BurialData data)
            {
                var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
                Tensor<float> score = result.First().AsTensor<float>();
                var prediction = new Prediction { PredictedValue = score.First() };
                result.Dispose();
                return Ok(prediction);
            }
        }

    
}
