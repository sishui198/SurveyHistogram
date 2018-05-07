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

    class DrillModel
    {        
        private string programName;//项目名称
        private string drillCode;//钻孔编号
        private double drillHoleStadardHeight;//孔口标高
        private double drillLocation;//钻孔位置
        private double coordinateX;//钻孔坐标X
        private double coordinateY;//钻孔坐标Y
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

    //工程
    class Project
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


}