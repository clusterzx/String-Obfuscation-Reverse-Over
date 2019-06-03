
**

## String Obfuscation Reverse Over (SoRevo)

**
**Usage:**

    Dim ReadOnly sOREVO As New ClusterzTools.SoRevo
    Dim ReadOnly testString As String = "Das ist ein Test\WTF\/NICE!#+ü+++`??`="
    Dim ReadOnly revForwStr As String = sOREVO.RevForw(testString)
    Dim ReadOnly revBackStr As String = sOREVO.RevBack(revForwStr)

**Output:**

    RHNpdGVuVHNcVFxOQyErKys/YGEgcyBpIGV0V0YvSUUj/CtgPz0=
	#########################################
	Das ist ein Test\WTF\/NICE!#+ü+++`??`=

**Conclusion:**

	You can can manipulate strings in multiple stages. Like this example:
	String(Clear) -> Reverse -> Scramble -> Base64
	Its an easy and but simple solution for quick sourcecode obfuscation.
	It wont stop reversing, but it will be a little harder to read.

Feel free to modify and use!
Credits: Clusterzx
