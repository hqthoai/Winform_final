
//Multiple face detection and recognition in real time
//Using EmguCV cross platform .Net wrapper to the Intel OpenCV image processing library for C#.Net
//Writed by Sergio Andrés Guitérrez Rojas
//"Serg3ant" for the delveloper comunity
// Sergiogut1805@hotmail.com
//Regards from Bucaramanga-Colombia ;)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;

namespace MultiFaceRec
{
    public partial class CheckAttendanceForm : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        MCvAvgComp[][] faceDetected;

        private void bt_Add_Click(object sender, EventArgs e)
        {


            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(txb_Name.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txb_Name.Text = "";
            txb_ID.Text = "";
            txb_YearBorn.Text = "";
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            //khởi tạo thiết bị
            grabber = new Capture();
            grabber.QueryFrame();
            //Khởi tạo sự kiện FrameGrabber
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void bt_CheckAttendace_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bt_Stastictis.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b = lb_RegconPerSon.Text;
            if ((lb_RegconPerSon.Text != "") && (b != a))
            {
                listBox_Active.Items.Add(lb_RegconPerSon.Text.ToUpper() + " " + lb_time.Text.ToUpper());
                bt_CheckAttendace.PerformClick();
            }
            a = lb_RegconPerSon.Text;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("T");
            lb_Date.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bt_Stastictis.Enabled = true;
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", "");
            CheckAttendanceForm.ActiveForm.Dispose();
            CheckAttendanceForm reload = new CheckAttendanceForm();
            reload.Show();
        }

        EigenObjectRecognizer recognizer;
        string a, b;
        public CheckAttendanceForm()
        {
            //InitializeComponent();
            ////Load haarcascades for face detection
            //face = new HaarCascade("haarcascade_frontalface_default.xml");
            ////eye = new HaarCascade("haarcascade_eye.xml");
            //try
            //{
            //    //Load of previus trainned faces and labels for each image
            //    string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
            //    string[] Labels = Labelsinfo.Split('%');
            //    NumLabels = Convert.ToInt16(Labels[0]);
            //    ContTrain = NumLabels;
            //    string LoadFaces;

            //    for (int tf = 1; tf < NumLabels + 1; tf++)
            //    {
            //        LoadFaces = "face" + tf + ".bmp";
            //        trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
            //        labels.Add(Labels[tf]);
            //    }

            //}
            //catch (Exception e)
            //{
            //    //MessageBox.Show(e.ToString());
            //    //MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

        }
        void FrameGrabber(object sender, EventArgs e)
        {
            lb_NumberRegcon.Text = "0";
            NamePersons.Add("");
            //Nhận thiết bị chụp khung hình hiện tại
            currentFrame = grabber.QueryFrame().Resize(450, 300, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            gray = currentFrame.Convert<Gray, byte>();
            //Nhận diện khuôn mặt
            faceDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Hành động cho từng yếu tố được phát hiện
            foreach (MCvAvgComp f in faceDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //Vẽ Mặt được phát hiện trong kênh 0 (màu xám) với màu đỏ
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 1);

                if (trainingImages.ToArray().Length != 0)
                {
                    //Tiêu Chí Thuật Ngữ để nhận dạng khuôn mặt với số lượng hình ảnh được đào tạo như maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                    //Nhận dạng khuôn mặt Eigen
                    recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, ref termCrit);
                    name = recognizer.Recognize(result);
                    //Vẽ Nhãn cho mỗi khuôn mặt được phát hiện và nhận dạng
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                }
                NamePersons[t - 1] = name;
                NamePersons.Add("");
                //Đặt số lượng khuôn mặt  được phát hiện  trên ảnh
                lb_NumberRegcon.Text = faceDetected[0].Length.ToString();

            }

            t = 0;
            // tên ghép của những người được công nhận
            for (int nnn = 0; nnn < faceDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + " ";
            }
            //Hiển thị các khuôn mặt được cung cấp và công nhận 
            imageBoxFrameGrabber.Image = currentFrame;
            lb_RegconPerSon.Text = names;
            names = "";
            //Xóa danh sách (vector) tên
            NamePersons.Clear();
        }
        
    }
}