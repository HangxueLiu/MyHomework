# MyHomework 
## 零 前期准备 
### 一 在vs上下载GitHub插件
第一次在vs上安装GitHub插件失败  
第二次更改host文件将其变为空白，继续失败  
第三次推断可能是网络原因更换网络后重新下载，下载成功。  
### 二 将vs本地存储库与远程GitHub存储库连接
旧理解：本地存储库和远程存储库是两个完全不相干的库，vs的GitHub可以将本地文件上传到远程GitHub库备份  
新理解：远程存储库是本地存储库的备份，即整个库同步，所以整个文件夹的改动都会被同步到远程存储库。要同步的文件必须在本地存储库中  
rejected Updates were rejected because the remote contains work that you do not have locally. This is usually caused by another repository pushing to the same ref. You may want to first integrate the remote changes before pushing again.  
经过查资料发现是因为我们在本地新建库后，与远程仓库的内容不一致导致的。为此在我向远程库推送的时候，要先进行pull，让本地新建的库和远程库进行同步。  
## 作业一 
只需在代码最后加一句恢复颜色的代码.  
Console.ResetColor()  

![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework1%20resetColor.png)

## 作业二 

### hello world1 
非静态方法实现printHelloWorld并在开头和结尾用foreach输出命令行参数  
![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloworld12.png)
### hello world2
静态方法实现无需实例化对象  
![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloworld12.png)

### hello world3 
新建一个名为hellworld的button 点击后弹出HelloWorld的命令框button背景为绿色  
![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloworld3.png)  
![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloword3(2).png)  
### hello world4 
WindowsForm项目中进行类似3中的操作   

![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloWorld4.png)  

![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homeworld2%20helloWorld4(2).png)  
### hello world5 
新建一个Android空项目，打开mainactivity把label1后面的字符串改成helloWorld  

![](https://github.com/HangxueLiu/MyHomework/blob/master/picture/%E4%BD%9C%E4%B8%9A%E4%B8%80%EF%BC%8C%E4%BA%8C%E5%9B%BE%E7%89%87/homework2%20helloWorld5.jpg?raw=true)  

## 作业三  
### 目标
#### 实现一个功能和视频演示相同的WPF APP  
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework3/homework3/picture/1.png)  
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework3/homework3/picture/2.png)
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework3/homework3/picture/3.png)


## 作业四
### 目标
#### 学会使用vs2017 web API
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework4/picture/1.png)  
#### 为了通过ID获得产品，输入ID并点击Search
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework4/picture/2.png)  
#### 如果你输入了一个无效的ID，那么服务器就会返回HTTP错误消息。
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework4/picture/3.png)  
#### F12来打开工具。点击Network面板，并点击Start Capturing。现在返回到web页面，并按F5来重新加载web页面。IE将会捕捉到浏览器和web服务器之间的HTTP传输。下图显示了一个页面的所有HTTP传输。  
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework4/picture/4.png)  
#### 定位到相对URI”api/products/“。  
![](https://github.com/HangxueLiu/MyHomework/blob/master/homework4/picture/4.png)  
