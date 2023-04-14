using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MummiesTestAPI.Data
{

    public class BurialData
    {
        //put references to each of the columns here

        public float sqns { get; set; }
        public float sqew { get; set; }
        public float depth { get; set; }
        public float headdirection_ { get; set; }
        public float headdirection_E { get; set; }
        public float headdirection_I { get; set; }
        public float headdirection_N_LL { get; set; }
        public float headdirection_W { get; set; }
        public float adultsubadult_ { get; set; }
        public float adultsubadult_A { get; set; }
        public float adultsubadult_C { get; set; }
        public float adultsubadult_N_LL { get; set; }
        public float material_Linen { get; set; }
        public float material_Linen_background { get; set; }
        public float material_Linen_red { get; set; }
        public float material_Linen_very_loosely_spun { get; set; }
        public float material_None { get; set; }
        public float material_Other { get; set; }
        public float material_Other_burlap { get; set; }
        public float material_Wool { get; set; }
        public float material_Wool_tapestry { get; set; }
        public float material_Wool_thread { get; set; }
        public float ply_1 { get; set; }
        public float ply_2 { get; set; }
        public float ply_D { get; set; }
        public float ply_None { get; set; }
        public float ply_S { get; set; }
        public float ns_N { get; set; }
        public float ew_E { get; set; }
        public float ew_None { get; set; }
        public float ew_W { get; set; }





    public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {

                sqns, sqew, depth, headdirection_, headdirection_E, headdirection_I, headdirection_N_LL, headdirection_W, adultsubadult_,
                adultsubadult_A, adultsubadult_C, adultsubadult_N_LL, material_Linen, material_Linen_background, material_Linen_red,
                material_Linen_very_loosely_spun, material_None, material_Other, material_Other_burlap, material_Wool, material_Wool_tapestry,
                material_Wool_thread, ply_1, ply_2, ply_D, ply_None, ply_S, ns_N, ew_E, ew_None, ew_W

    };
        int[] dimensions = new int[] { 1, 31 };
            return new DenseTensor<float>(data, dimensions);
        }

    }
}
