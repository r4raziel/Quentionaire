using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace questionnaire.Formulatrix
{   
    public interface IFrameCallback
    {
        public void FrameReceived(IntPtr pFrame, int pixelWidth, int pixelHeight);
    }
    public interface IValueReporter
    {
        public void Report(double value);
    }

    public class ExternalValueReporter : IValueReporter
    {
        public void Report(double value)
        {
            Console.WriteLine($"reported value: {value}");
        }
    }
    public class FrameCalculateAndStream
    {
        private IValueReporter _reporter;
        private Queue<Frame> _receivedFrames = new Queue<Frame>();
        private Timer _timer;
        public FrameCalculateAndStream(FrameGrabber fg, IValueReporter vr)
        {
            fg.OnFrameUpdated += HandleFrameUpdated;
            // Allocate a buffer and pin it to get an IntPtr for FrameReceived
            byte[] buffer = new byte[4];
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                fg.FrameReceived(handle.AddrOfPinnedObject(), 2, 2);
            }
            finally
            {
                handle.Free();
            }
            _timer = new Timer(5000);
            _timer.Elapsed += OnTimerElapsed;
            _reporter = vr;
        }
        private void HandleFrameUpdated(Frame frame)
        {
            _receivedFrames.Enqueue(frame);
        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_receivedFrames.Count > 0)
            {
                Frame frame = _receivedFrames.Dequeue();
                byte[] raw = frame.GetRawData();
                // https://stackoverflow.com/questions/29312223/finding-the-arithmetic-mean-of-an-array-c-sharp
                int sum = 0;
                for (int i = 0; i < raw.Length; i++)
                    sum += raw[i];
                int result = sum / raw.Length; // result now has the average of those numbers.
                _reporter.Report(result);
                frame.Dispose();
            }
            else {
                _timer.Enabled = false;
                _timer.Stop();
                _timer.Dispose();
                Console.WriteLine("Press Enter to exit the program.");
            }
        }
        public void StartStreaming()
        {
            _timer.Enabled = true;          
            Console.ReadLine();

        }
    }
    public class FrameGrabber : IFrameCallback
    {
        private byte[] _buffer;
        public delegate void FrameUpdateHandler(Frame rawFrame);
        public event FrameUpdateHandler OnFrameUpdated;
        public void FrameReceived(IntPtr frame, int width, int height)
        {
            if (_buffer == null)
                _buffer = new byte[width * height];
            // https://stackoverflow.com/questions/5486938/c-sharp-how-to-get-byte-from-intptr
            Marshal.Copy(frame, _buffer, 0, width * height);
            Frame bufferedFrame = new Frame(_buffer);
            OnFrameUpdated(bufferedFrame);
            //bufferedFrame.Dispose();
        }
    }
    public class Frame : IDisposable
    {
        private bool _disposed;
        private byte[] _rawBuffer;
        public Frame(byte[] raw)
        {
            _rawBuffer = raw;
        }

        public byte[] GetRawData()
        {
            if (_disposed)
                throw new ObjectDisposedException("underlying buffer has changed, should not be used anymore");
            return _rawBuffer;
        }
        public void Dispose()
        {
            _disposed = true;
        }
    }
}
