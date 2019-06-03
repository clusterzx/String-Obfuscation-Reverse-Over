
**

## String Obfuscation Reverse Over (SoRevo)

**
**Usage:**

    Dim ReadOnly sOREVO As New ClusterzTools.SoRevo
    Dim ReadOnly testString As String = "Das ist ein Test\WTF\/NICE!#+ü+++`??`="
    Dim ReadOnly revForwStr As String = sOREVO.RevForw(testString)
    Dim ReadOnly revBackStr As String = sOREVO.RevBack(revForwStr)

**Output:**

RHNpdGVuVHNcVFxOQyErKys/YGEgcyBpIGV0V0YvSUUj/CtgPz0= (Obfuscated)
#########################################
Das ist ein Test\WTF\/NICE!#+ü+++`??`=		     (DeObfuscated)

**Conclusion:**

	You can can manipulate strings in multiple stages. Like this example:
	String(Clear) -> Reverse -> Scramble -> Base64
	Its an easy and but simple solution for quick sourcecode obfuscation.
	It wont stop reversing, but it will be a little harder to read.
	Within just 1 function call u can deobfsucate it back to plain text.

Feel free to modify and use!
Credits: Clusterzx
