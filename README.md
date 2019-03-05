# MyHomework
## 零 前期准备
### 一 在vs上下载GitHub插件
<p>第一次在vs上安装GitHub插件失败</p>
<p>第二次更改host文件将其变为空白，继续失败</p>
<p>第三次推断可能是网络原因更换网络后重新下载，下载成功。</p>
### 二 将vs本地存储库与远程GitHub存储库连接
<p>旧理解：本地存储库和远程存储库是两个完全不相干的库，vs的GitHub可以将本地文件上传到远程GitHub库备份</p>
<p>新理解：远程存储库是本地存储库的备份，即整个库同步，所以整个文件夹的改动都会被同步到远程存储库。要同步的文件必须在本地存储库中</p>
<p>rejected Updates were rejected because the remote contains work that you do not have locally. This is usually caused by another repository pushing to the same ref. You may want to first integrate the remote changes before pushing again.</p>
<p>经过查资料发现是因为我们在本地新建库后，与远程仓库的内容不一致导致的。为此在我向远程库推送的时候，要先进行pull，让本地新建的库和远程库进行同步。</p>
## 作业一
<p>只需在代码最后加一句恢复颜色的代码.</p> 
<i>Console.ResetColor</i>
![Alt Text](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework1%20resetColor.png)

## 作业二
### hello world1
<p>非静态方法实现printHelloWorld并在开头和结尾用foreach输出命令行参数</p>
https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloworld12.png
### hello world2
<p>静态方法实现无需实例化对象</p>
https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloworld12.png
### hello world3
<p>新建一个名为hellworld的button 点击后弹出HelloWorld的命令框button背景为绿色</p>
https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloworld3.png
https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloword3(2).png
### hello world4
<p>WindowsForm项目中进行类似3中的操作</p>
https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloWorld4.png


