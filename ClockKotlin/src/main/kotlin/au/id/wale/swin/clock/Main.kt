package au.id.wale.swin.clock

fun main() {
    val clock = Clock()
    // Loop 120 times (120 ticks = 120 seconds), which *should* equal 2 hours.
    for (i in 1..120) {
        clock.tick()
        Thread.sleep(400) // Update every 400 milliseconds
        print("\r${clock.currentTime}")
    }
}