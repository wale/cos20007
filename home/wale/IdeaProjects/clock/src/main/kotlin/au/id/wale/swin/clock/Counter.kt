package au.id.wale.swin.clock

class Counter {
    private var _count: Int = 0

    val count: Int
        get() = _count

    fun increment() = _count++

    fun reset() {
        _count = 0
    }
}