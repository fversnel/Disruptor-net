namespace Disruptor
{
    /// <summary>
    /// Used to record the batch of sequences claimed in a <see cref="Sequencer"/>.
    /// </summary>
    public struct BatchDescriptor {
        private readonly int _size;
        private long _end;

        ///<summary>
        /// Create a holder for tracking a batch of claimed sequences in a <see cref="Sequencer"/>
        ///</summary>
        ///<param name="size">size of the batch to claim</param>
        internal BatchDescriptor(int size)
        {
            _size = size;
            _end = -1;
        }

        /// <summary>
        /// Get the start sequence number of the batch.
        /// </summary>
        public long Start
        {
            get { return End - (_size - 1L); }
        }

        /// <summary>
        /// Get the size of the batch.
        /// </summary>
        public int Size {
            get { return _size; } 
        }

        ///<summary>
        /// Get the end sequence number of the batch
        ///</summary>
        public long End {
            get { return _end; }
            set { _end = value; } 
        }
    }
}