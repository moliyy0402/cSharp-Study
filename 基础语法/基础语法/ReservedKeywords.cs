/**
 * 在任何 C# 程序中的第一条语句都是：using System;
标识符
标识符是用来识别类、变量、函数或任何其它用户定义的项目。在 C# 中，类的命名必须遵循如下基本规则：
标识符必须以字母、下划线或 @ 开头，后面可以跟一系列的字母、数字（ 0 - 9 ）、下划线（ _ ）、@。
标识符中的第一个字符不能是数字。
标识符必须不包含任何嵌入的空格或符号，比如 ? - +! # % ^ & * ( ) [ ] { } . ; : " ' / \。
标识符不能是 C# 关键字。除非它们有一个 @ 前缀。 例如，@if 是有效的标识符，但 if 不是，因为 if 是关键字。
标识符必须区分大小写。大写字母和小写字母被认为是不同的字母。
不能与C#的类库名称相同。

关键字:
abstract	as	base	bool	break	byte	case
catch	char	checked	class	const	continue	decimal
default	delegate	do	double	else	enum	event
explicit	extern	false	finally	fixed	float	for
foreach	goto	if	implicit	in	in (generic
modifier)	int
interface	internal	is	lock	long	namespace	new
null	object	operator	out	out
(generic
modifier)	override	params
private	protected	public	readonly	ref	return	sbyte
sealed	short	sizeof	stackalloc	static	string	struct
switch	this	throw	true	try	typeof	uint
ulong	unchecked	unsafe	ushort	using	virtual	void
volatile	while					
上下文关键字
add	alias	ascending	descending	dynamic	from	get
global	group	into	join	let	orderby	partial
(type)
partial
(method)	remove	select	set




3、VS中常用的快捷键

　　Ctrl + k +d  快速对齐代码

　　Ctrl + z  撤销

　　Ctrl + s  保存

　　Ctrl + j  快速弹出智能提示

　　Shift + End、Shift + Home、Shift + 上下左右  选中单行内容

　　Ctrl + k + c 快速注释选中内容

　　Ctrl + k + u 快速取消注选中的注释内容

　　Alt + Shift +F10 添加命名空间

　　F1 转到帮助

　　F12 查看类型定义

　　#region ...#endregion  折叠代码

添加注释：ctrl+k+c
撤销注释：ctrl+k+u


4、波浪线
　　1)、如果你的代码中出现了红色的波浪线，意味着你的代码中出现了语法错误。
　　2)、如果你的代码中出现了绿色的波浪线，说明你的代码语法并没有错误，只不过提示你有可能会出现错误，但是不一定会出现错误。警告线
 */
namespace 基础语法
{
    internal class ReservedKeywords
    {

    }
}
