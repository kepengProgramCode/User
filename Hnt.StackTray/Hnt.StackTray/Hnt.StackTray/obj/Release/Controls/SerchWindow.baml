   M S B A M L   `   `   `  ����   Hnt.StackTray(    "Hnt.StackTray.Controls.SerchWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     $
��14px(�  � 	Resources   �� MergedDictionaries �� Source��  �� $% /Resources/DictionaryStyle.xaml?�%    .��� 
�������.+��� $��托盘码或批次:��$
��Left=�$	��Top=�$��15(�$��	30,10,0,0q��� -   $��barCode��$
��Left=�$	��Top=�$	��100��$��30��$��15(�$��
140,10,0,0q�$��Center=��� $��开始时间:��$
��Left=�$	��Top=�$��15(�$��
260,10,0,0q�(  "System.Windows.Controls.DatePicker  -   $��	startTime��$
��Left=�$	��Top=�$��15(�|�.  $	��130��$��30��$��
340,10,0,0q�$��Center=��� $��截止时间:��$
��Left=�$	��Top=�$��15(�$��
490,10,0,0q�  -   $��endTime��$
��Left=�$	��Top=�$��15(�|�.  $	��130��$��30��$��
570,10,0,0q�$��Center=��� -   $��查询��$��40,10q�$��80��$��30��   ButtonQueryStyle#���   �� -   $��HistoryData��$��30,50,30,60q�  DefaultListView#���  ���� *
ListBind+ �� View ��   DefaultGridViewColumnHeader! �� ColumnHeaderContainerStyle# �  .P���  �� Width$	 100��$��编号�� �� CellTemplate �� .R���  �� TextAlignment$ Center=����� *Id+ �� Mode$ TwoWay=��� $	 200��$��	托盘码�� �� .R��� $ Center=����� *	Barcode+$ TwoWay=��� $	 200��$��批次�� �� .R��� $ Center=����� *Batch+$ TwoWay=��� $	 200��$��时间�� �� .R��� $ Center=����� *
UpdateTime+$ TwoWay=��� $	 163��$��操作�� �� .R�� $	��110��	 � ColumnDefinitions	 �� $
��50px ��� $
��50px �.+��� $��update��-   $��0��$��0��$
��Left=�$��24��$��24��$��10,0,0,0q�  ButtonImage#���  
 � DataContext
 �� *Id+$ TwoWay=�.���� $��../Images/Edit.png���� $��delete��-   $��0��$��1��$
��Left=�$��24��$��24��$��10,0,0,0q�#���  
 �� *Id+$ TwoWay=�.���� $��../Images/Delete.png����  �� Orientation$ 
Horizontal=�$��Right=�$��Bottom=�$��	0,0,30,20q�.+��� -    ��Name$ 
btnonPages��$��	上一页��  PageTurnningButtonStyle#���  �� $��Center=��� .F��� $��【共���� $� ���� .F��� -	    ��Name$ txtBlock�����#922C88���� *Total+�� $� ���� .F��� $��页】���� $� ���� .F��� $��	【当前���� $� ���� .F��� ���#922C88���� *CurrentSize+�� $� ���� .F��� $��页】���� -
   $ btnnextPages��$��	下一页��#���  