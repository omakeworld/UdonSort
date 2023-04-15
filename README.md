# UdonSort

UdonSharpで配列のソート機能が使えないため、Udonで使えるソート機能を実装。

## 機能

* 配列の昇順ソート
  * 対応型：int[]


## 使い方

`UdonSort.Sort(配列);`

例：

```C#
int[] array = new int[5];
array[0] = 5;
array[1] = 1;
array[2] = 8;
array[3] = 3;
array[4] = 10;

UdonSort.Sort(array);

string str = string.Empty;
foreach(int i in array)
{
    str += i.ToString() + ",";
}
Debug.Log(str);


```

## 補足

（Udonであっても）配列は参照渡しなのでSortを呼び出すだけでOKです。
