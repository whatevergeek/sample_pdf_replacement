#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            string pdfpath = @".\..\..\sample_pdf.pdf";

            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(pdfpath);

            //Get all the pages
            foreach (PdfLoadedPage loadedPage in loadedDocument.Pages)
            {
                foreach (PdfLoadedAnnotation annotation in loadedPage.Annotations)
                {
                    if (annotation is PdfLoadedFreeTextAnnotation)
                    {
                        PdfLoadedFreeTextAnnotation freeText = annotation as PdfLoadedFreeTextAnnotation;

                        freeText.Text = "Hello";
                    }
                }
            }
            //Save and close the PDF document instance
            loadedDocument.Save(@".\..\..\sample_pdf_output.pdf");
            loadedDocument.Close(true);
        }
    }
}
