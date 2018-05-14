﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    //==============================================================
    //  author：fengxiaojuan
    //  时间：2018/5/5 11:15:04
    //  文件名：editting...
    //==============================================================

    public class DrillModel
    {
        public string ProgramName { get; set; }//项目名称
        public string DrillCode { get; set; }//钻孔编号        
        public double WaterDepth { get; set; }//水位深度
        public string RecommandBearing { get; set; }//推荐承载力
        public double DrillHoleStadardHeight { get; set; }//孔口标高
        public double CoordinateX { get; set; }//钻孔坐标X
        public double CoordinateY { get; set; }//钻孔坐标Y
        public string DrillHistogramScale { get; set; }//钻孔柱状图比例尺
        public string LegendId { get; set; }//图例号

        //public string DrogramName
        //{
        //    get;
        //    set;

        //}
        //public string DrillCode
        //{
        //    get;
        //    set;

        //}
        //public double WaterDepth
        //{
        //    get;
        //    set;

        //}
        //public double RecommandBearing
        //{
        //    get;
        //    set;

        //}
        //public double DrillHoleStadardHeight
        //{
        //    get;
        //    set;

        //}
        //public double CoordinateX
        //{
        //    get;
        //    set;

        //}
        //public string CoordinateY
        //{
        //    get;
        //    set;

        //}
        //public string DrillHistogramScale
        //{
        //    get;
        //    set;

        //}
        //public double LegendId
        //{
        //    get;
        //    set;

        //}
    }

    //工程
    public class Project
    {
        public Project()
        { }
        private string projectName;//工程名称
        private string startTime;//开始时间
        private string endTime;//结束时间

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }

        }
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }

        }
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }

        }

    }

    //地层地质
    public class DrillGeologyModel
    {
        private string strataCode;//地层编号
        private string strataID;//地层代号
        private double startDeep;//开始深度
        private double endDeep;//结束深度
        private double thickness;//厚度
        private double bottomElevation;//层底标高
        private string strataDescription;//地层描述
        private string legendNO;//图例号
        private double legendHeight;//图例高度
        private double legendWidth;//图例宽度
        private string legendExplation;//图例说明
        private string contactRelation;//接触关系
        private string coreTake;//岩芯采取
        private string density;//密度
        private string waterInclude;//含水量
        private string remarks;//备注

        public string StrataCode
        {
            get { return strataCode; }
            set { strataCode = value; }

        }
        public string StrataID
        {
            get { return strataID; }
            set { strataID = value; }

        }
        public double StartDeep
        {
            get { return startDeep; }
            set { startDeep = value; }

        }
        public double EndDeep
        {
            get { return endDeep; }
            set { endDeep = value; }

        }
        public double Thickness
        {
            get { return thickness; }
            set { thickness = value; }

        }
        public double BottomElevation
        {
            get { return bottomElevation; }
            set { bottomElevation = value; }

        }
        public string StrataDescription
        {
            get { return strataDescription; }
            set { strataDescription = value; }

        }
        public string LegendNO
        {
            get { return legendNO; }
            set { legendNO = value; }

        }
        public double LegendHeight
        {
            get { return legendHeight; }
            set { legendHeight = value; }

        }
        public double LegendWidth
        {
            get { return legendWidth; }
            set { legendWidth = value; }

        }
        public string LegendExplation
        {
            get { return legendExplation; }
            set { legendExplation = value; }

        }
        public string ContactRelation
        {
            get { return contactRelation; }
            set { contactRelation = value; }

        }
        public string CoreTake
        {
            get { return coreTake; }
            set { coreTake = value; }

        }
        public string Density
        {
            get { return density; }
            set { density = value; }

        }
        public string WaterInclude
        {
            get { return waterInclude; }
            set { waterInclude = value; }

        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }

        }

    }

    //花纹库
    public class PatternModel
    {
        public PatternModel()
        { }
        public PatternModel(string id, string name, string show)
        {
            Code = id;
            Name = name;
            Show = show;
        }
        //[DataMember]            //对方法2要设置成员属性
        public string Code
        {
            get;
            set;
        }
        //[DataMember]
        public string Name
        {
            get;
            set;
        }
        //[DataMember]
        public string Show
        {
            get;
            set;
        }

    }
}
