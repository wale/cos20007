package au.id.wale.swin.clock

class Clock {
    private var seconds = Counter()
    private var minutes = Counter()
    private var hours = Counter()

    val currentTime: String
        get() {
            val formattedHours = "%02d".format(hours.count)
            val formattedMinutes = "%02d".format(minutes.count)
            val formattedSeconds = "%02d".format(seconds.count)

            return "${formattedHours}:${formattedMinutes}:${formattedSeconds}"
        }

    fun reset() {
        seconds.reset()
        minutes.reset()
        hours.reset()
    }

    fun tick() {
        if(seconds.count < 59) {
            seconds.increment()
        } else {
            seconds.reset()
            if(minutes.count < 59) {
                minutes.increment()
            } else {
                minutes.reset()
                if (hours.count >= 23) {
                    hours.reset()
                } else {
                    hours.increment()
                }
            }
        }
    }
}