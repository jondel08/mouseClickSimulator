using System.Runtime.InteropServices;
using System.Timers;

namespace MouseClick {
    public partial class Form1:Form {

        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private System.Timers.Timer clickTimer;
        private System.Timers.Timer countdownTimer;
        private int countdown;
        private int clickCount = 0;

        public Form1() {
            InitializeComponent();
            clickTimer=new System.Timers.Timer(60000); // 1 minuto en milisegundos
            clickTimer.Elapsed+=PerformMouseClick;

            countdownTimer=new System.Timers.Timer(1000); // 1 segundo
            countdownTimer.Elapsed+=UpdateCountdown;
        }

        private void btnClick_Click(object sender, EventArgs e) {
            countdown=60;
            clickTimer.Start();
            countdownTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            clickTimer.Stop();
            countdownTimer.Stop();
        }

        private void PerformMouseClick(object sender, ElapsedEventArgs e) {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            clickCount++;
            countdown=60;
            this.Invoke((MethodInvoker)delegate {
                if (this.Controls["clickCountLabel"] is Label clickCountLabel) {
                    clickCountLabel.Text=$"Clics realizados: {clickCount}";
                }
            });
        }

        private void UpdateCountdown(object sender, ElapsedEventArgs e) {
            if (countdown>0) {
                countdown--;
                this.Invoke((MethodInvoker)delegate {
                    if (this.Controls["countdownLabel"] is Label countdownLabel) {
                        countdownLabel.Text=$"Tiempo hasta el próximo clic: {countdown}";
                    }
                });
            }
        }
    }
}
