# mostFrequentWord


Mot le plus fréquent

Étant donné un paragraphe et un string array de mots interdits, retourner le mot le plus fréquent qui n'est pas interdit. Il est garanti qu'il y ait au moins un mot qui ne soit pas interdit, et que la réponse soit unique.

Les mots du paragraphe ne sont pas sensibles à la casse et la réponse doit être retournée en minuscules.


Exemple 1 :

Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
Output: "ball"
Explanation: 
Le mot « hit » apparaît 3 fois, mais c'est un mot interdit.
Le mot « ball » apparaît deux fois (et aucun autre mot ne le fait), c'est donc le mot non interdit le plus fréquent dans le paragraphe. 
Notez que les mots du paragraphe ne sont pas sensibles à la casse,
que la ponctuation est ignorée (même si elle est adjacente à un mot, comme « balle »), 
et que « hit » n'est pas la réponse même s'il apparaît plus souvent parce qu'il est interdit.

Example 2:

Input: paragraph = "a.", banned = []

Exemple 2 :

Entrée : paragraph = « a. », interdit = []
Sortie : « a »
 

Contraintes :

1 <= paragraph.length <= 1000
Le paragraphe est composé de lettres anglaises, d'un espace ' ', ou de l'un des symboles : « !?', ;. ».
0 <= banned.length <= 100
1 <= banned[i].length <= 10
banned[i] est composé uniquement de lettres minuscules anglaises.

In English:
Most common word

Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.

The words in paragraph are case-insensitive and the answer should be returned in lowercase.

 

Example 1:

Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
Output: "ball"
Explanation: 
"hit" occurs 3 times, but it is a banned word.
"ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
Note that words in the paragraph are not case sensitive,
that punctuation is ignored (even if adjacent to words, such as "ball,"), 
and that "hit" isn't the answer even though it occurs more because it is banned.
Example 2:

Input: paragraph = "a.", banned = []
Output: "a"
 

Constraints:

1 <= paragraph.length <= 1000
paragraph consists of English letters, space ' ', or one of the symbols: "!?',;.".
0 <= banned.length <= 100
1 <= banned[i].length <= 10
banned[i] consists of only lowercase English letters.


