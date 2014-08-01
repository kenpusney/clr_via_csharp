
def signum(x:Int) = if (x == 0) 0 else x / x.abs

def countdown(n:int) = (1 to n).reverse foreach println

def product(m:String) = m.foldLeft(1)({ _ * _ })

def product(m:String, n:Int=1):Int = {
	if(m.length == 0) n 
	else product(m.drop(1), n * m(0))
}


import  scala.util.Random
def randary(n:Int):Seq[Int] = for( i <- 0 to n) yield Random.nextInt(n)

def avg(z:Array[Double]): Double = z.sum / z.length

//Swap two neighbours
for {
	i <- 0 to z.length;
	m = if( i % 2 == 0) 1 else -1;
	if i + m < z.length;
} yield z(i + m);

def unique[T](array:Array[T]):Array[T] = array.distinct

java.util.TimeZone.getAvailableIDs
	.filter {_.contains("America/")} 
	.map {_.replace("America/","")} 
	.sorted
