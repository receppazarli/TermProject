﻿
namespace Comp337.WebFormsUI.Forms
{
    partial class FrmCoordinatorMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.btnCourses = new DevExpress.XtraBars.BarButtonItem();
            this.btnInstructors = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudents = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAssignmentOfTranier = new DevExpress.XtraBars.BarButtonItem();
            this.btnAssignmentOfAdvisor = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserInformation = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnHomePage,
            this.btnCourses,
            this.btnInstructors,
            this.btnStudents,
            this.barButtonItem5,
            this.btnAssignmentOfTranier,
            this.btnAssignmentOfAdvisor,
            this.btnUserInformation,
            this.btnSettings});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.Size = new System.Drawing.Size(949, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Caption = "Home Page";
            this.btnHomePage.Id = 1;
            this.btnHomePage.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.home_16x161;
            this.btnHomePage.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.home_32x321;
            this.btnHomePage.Name = "btnHomePage";
            // 
            // btnCourses
            // 
            this.btnCourses.Caption = "Courses";
            this.btnCourses.Id = 2;
            this.btnCourses.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.content_16x16;
            this.btnCourses.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.content_32x32;
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCourses_ItemClick);
            // 
            // btnInstructors
            // 
            this.btnInstructors.Caption = "Instructors";
            this.btnInstructors.Id = 3;
            this.btnInstructors.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.meeting_16x16;
            this.btnInstructors.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.meeting_32x32;
            this.btnInstructors.Name = "btnInstructors";
            // 
            // btnStudents
            // 
            this.btnStudents.Caption = "Students";
            this.btnStudents.Id = 4;
            this.btnStudents.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.customers_16x16;
            this.btnStudents.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.customers_32x32;
            this.btnStudents.Name = "btnStudents";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "ADVISORS";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnAssignmentOfTranier
            // 
            this.btnAssignmentOfTranier.Caption = "Assignment Of Tranier";
            this.btnAssignmentOfTranier.Id = 6;
            this.btnAssignmentOfTranier.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.assignto_16x16;
            this.btnAssignmentOfTranier.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.assignto_32x321;
            this.btnAssignmentOfTranier.Name = "btnAssignmentOfTranier";
            // 
            // btnAssignmentOfAdvisor
            // 
            this.btnAssignmentOfAdvisor.Caption = "Assignment Of Advisor";
            this.btnAssignmentOfAdvisor.Id = 7;
            this.btnAssignmentOfAdvisor.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.usergroup_16x16;
            this.btnAssignmentOfAdvisor.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.usergroup_32x32;
            this.btnAssignmentOfAdvisor.Name = "btnAssignmentOfAdvisor";
            // 
            // btnUserInformation
            // 
            this.btnUserInformation.Caption = "User Information";
            this.btnUserInformation.Id = 8;
            this.btnUserInformation.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.card_16x16;
            this.btnUserInformation.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.card_32x32;
            this.btnUserInformation.Name = "btnUserInformation";
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "Settings";
            this.btnSettings.Id = 9;
            this.btnSettings.ImageOptions.Image = global::Comp337.WebFormsUI.Properties.Resources.version_16x16;
            this.btnSettings.ImageOptions.LargeImage = global::Comp337.WebFormsUI.Properties.Resources.version_32x32;
            this.btnSettings.Name = "btnSettings";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHomePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCourses);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInstructors);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStudents);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAssignmentOfTranier);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAssignmentOfAdvisor);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUserInformation);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 594);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(949, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmCoordinatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 618);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmCoordinatorMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Coordinator Main";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnHomePage;
        private DevExpress.XtraBars.BarButtonItem btnCourses;
        private DevExpress.XtraBars.BarButtonItem btnInstructors;
        private DevExpress.XtraBars.BarButtonItem btnStudents;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnAssignmentOfTranier;
        private DevExpress.XtraBars.BarButtonItem btnAssignmentOfAdvisor;
        private DevExpress.XtraBars.BarButtonItem btnUserInformation;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}