using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Kitware.VTK;

namespace activizBtnTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.renderWindowControl = new Kitware.VTK.RenderWindowControl();
            this.renderWindowControl.AddTestActors = false;
            this.renderWindowControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderWindowControl.Location = new System.Drawing.Point(0, 0);
            this.renderWindowControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.renderWindowControl.Name = "renderWindowControl";
            this.renderWindowControl.Size = new System.Drawing.Size(617, 347);
            this.renderWindowControl.TabIndex = 0;
            this.renderWindowControl.TestText = null;
            this.renderWindowControl.Load += new System.EventHandler(this.renderWindowControl_Load);
            pictureBox1.Controls.Add(this.renderWindowControl);
        }

        private void renderWindowControl_Load(object sender, EventArgs e)
        {
            try
            {
                ReadSTL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK);
            }
        }
        public Kitware.VTK.RenderWindowControl renderWindowControl;

        vtkPolyDataMapper mapper;
        vtkActor[] actors;
        vtkRenderWindow renderWindow;
        vtkRenderer renderer;

        private void ReadSTL()
        {
            // Path to vtk data must be set as an environment variable
            // VTK_DATA_ROOT = "C:\VTK\vtkdata-5.8.0"
            string root = System.IO.Directory.GetCurrentDirectory(); // test.GetDataRoot();
            Trace.WriteLine(root);
            //string filePath = System.IO.Path.Combine(root, @"..\..\res\42400-IDGH.stl");
            string filePath = System.IO.Path.Combine(root, @"..\..\res\shark.ply");
            //string filePath = System.IO.Path.Combine(root, @"..\..\res\Torso.vtp");
            vtkPolyData polyData = ReadPolyData(filePath);
            mapper = vtkPolyDataMapper.New();
            mapper.SetInput(polyData);

           actors = new vtkActor[3];
            actors[0] = vtkActor.New();
            actors[0].SetMapper(mapper);
            actors[0].GetProperty().SetRepresentationToSurface();

           actors[1] = vtkActor.New();
            actors[1].SetMapper(mapper);
            actors[1].GetProperty().SetRepresentationToWireframe();

           actors[2] = vtkActor.New();
            actors[2].SetMapper(mapper);
            actors[2].GetProperty().SetRepresentationToPoints();

           // get a reference to the renderwindow of our renderWindowControl1
           renderWindow = renderWindowControl.RenderWindow;
            // renderer
            renderer = renderWindow.GetRenderers().GetFirstRenderer();
            // set background color
            renderer.SetBackground(0.2, 0.3, 0.4);
            // add our actor to the renderer
            renderer.AddActor(actors[0]);
            refresh();
        }

        vtkPolyData ReadPolyData(string fileName)
        {
            vtkPolyData polyData = vtkPolyData.New();
            string extension = System.IO.Path.GetExtension(fileName);
            if (extension == ".ply")
            {
                vtkPLYReader reader = vtkPLYReader.New();
                reader.SetFileName(fileName);
                reader.Update();
                polyData = reader.GetOutput();
            }
            else if (extension == ".vtp")
            {
                vtkXMLPolyDataReader reader = vtkXMLPolyDataReader.New();
                reader.SetFileName(fileName);
                reader.Update();
                polyData = reader.GetOutput();
            }
            else if (extension == ".obj")
            {
                vtkOBJReader reader = vtkOBJReader.New();
                reader.SetFileName(fileName);
                reader.Update();
                polyData = reader.GetOutput();
            }
            else if (extension == ".stl")
            {
                vtkSTLReader reader = vtkSTLReader.New();
                reader.SetFileName(fileName);
                reader.Update();
                polyData = reader.GetOutput();
            }
            else if (extension == ".vtk")
            {
                vtkPolyDataReader reader = vtkPolyDataReader.New();
                reader.SetFileName(fileName);
                reader.Update();
                polyData = reader.GetOutput();
            }
            else if (extension == ".g")
            {
                vtkBYUReader reader = vtkBYUReader.New();
                reader.SetGeometryFileName(fileName);
                reader.Update();
                polyData = reader.GetOutput();
            }
            else
            {
                vtkSphereSource source = vtkSphereSource.New();
                source.Update();
                polyData = source.GetOutput();
            }
            return polyData;
        }

        private void refresh()
        {
            renderWindow.AddRenderer(renderer);
            renderWindow.Render();
        }

        private void radioBtnSurf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSurf.Checked)
            {
                renderer.RemoveAllViewProps();
                renderer.AddActor(actors[0]);
                Trace.WriteLine("surface");
                refresh();
            }
        }

        private void radioBtnWire_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnWire.Checked)
            {
                renderer.RemoveAllViewProps();
                renderer.AddActor(actors[1]);
                Trace.WriteLine("wirefame");
                refresh();
            }
        }

        private void radioBtnPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPoints.Checked)
            {
                renderer.RemoveAllViewProps();
                renderer.AddActor(actors[2]);
                Trace.WriteLine("points");
                refresh();
            }
        }
    }
}
