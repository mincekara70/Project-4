   M S B A M L   `   `   `  ����I  EPocket Recipes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:RecipeWPFAppRecipeWPFApp  5      !    RecipeWPFApp.MainRecipePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:RecipeWPFApp     5        N� Title$  Featured��5	      .��5      ��  �� Padding$ 200, 0q�6   ._�5   
   �� -   5        $��recipe_page��5      .+�5      �� -   5        $��
recipeName��5      $��MAIN RECIPE��6*   $��25(�6=   $��	ExtraBold"�6K   
���  �� �� TextAlignment$ Center=�6s   �� 5      -   5        $��recipeImage��5      $n��hhttps://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ3zohGxG6qIgXm_bKEq6zGLKm6pOkDc4zehRnNUha4XixPBLD7��6'   $	��200��6�   �� 5      $��1��6   
�������$��50, 10q�6/   �� 5      $��0, 10, 0, 0q�6   $��Ingredients��61   $��20(�6D   $
��Bold"�6R   
���  ��6d   �� 5      -   5        $��recipeIngredients��5      �� 5      $��0, 10, 0, 0q�6   $��Instructions��61   $��20(�6E   $
��Bold"�6S   
���  ��6e   �� 5      -   5        $��recipeInstructions��5      $
��Wrap=�66   $��Step 1: ��6J   $��15(�6Z   �� 5      -   5        $��bookmark_button��5      $��Bookmark this recipe��60   ���#e04021���#fff6d   �� 5      -   5        $��	rate_form��5      .+�5      �� -   5        $��rate_form_title��5       $��Rate this recipe��67   
���  ��$
��Bold"�6`   $��0 15 0 0q�6r   �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� -	   5        $��rate_form_rating��5   "   $	��150��6V   $��Center=�6b   �� 5      -
   5        $��rate_form_button��5   !   $
��Rate��69   $	��100��6H   $��25 0 0 0q�6T   5      �� 5       -   5        $��rate_form_resultlabel��5        $��Center=�6=   $��18(�6Z   5!      �� 5#      $��0, 10, 0, 0q�6   $��Recommended��61   $��20(�6D   $
��Bold"�6R   �� 5$      $��1��6   
�������6'   � 5&      -   5        $
��grid��5&       � ColumnDefinitions 5'      �� 5(      $	��100 �6+   �� 5)      $��10 �6+   �� 5*      $��* �6+   5,      5-      5.      5/      