import markdown

with open('D:\Repo\Learning-Tutorial\Python\PythonApplication1\TextFile1.txt', 'r') as f:
    text = f.read()
    html = markdown.markdown(text)

with open('D:\Repo\Learning-Tutorial\Python\PythonApplication1\Picnic.html', 'w') as f:
    f.write(html)