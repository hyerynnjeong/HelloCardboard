# HelloCardboard: VR Fruit-Matching Game

COMP 590: Virtual Reality and Games — Assignment 1
Author: Hye-Rynn Jeong

## Overview
Built and deployed for Google Cardboard using Unity 6.5 (6000.5.9f1) and the
Google Cardboard XR Plugin. Deployed to an iPhone via Xcode (the iOS path
in the assignment).

Scenes:
- **HelloUnity** — a single cube (Step 4).
- **BallGame** — shoot a ball at a target when the Cardboard button is pressed (Step 5).
- **FruitGame** — my custom game (Step 6), below.

## My Game: Fruit Toss
The player stands in front of a row of four fruit crates: apple, banana,
pineapple, and orange — each visibly filled with its own fruit so it can be
identified at a glance. Pressing the Cardboard button launches a randomly
chosen fruit in the direction the player is looking, using the phone's head
tracking to aim. The goal is to sort each launched fruit into the crate that
matches it.

Scoring rewards accuracy and penalizes mistakes:
- Landing a fruit in its matching crate: +1
- Landing a fruit in the wrong crate: −1
- Missing all crates: no penalty

Because the player does not choose which fruit is launched, each throw is a
small problem to solve: identify the fruit that just spawned, locate its crate
somewhere in the row, and aim before the next throw. A 30-second timer
drives the pace, and a world-space UI board shows the current score and
remaining time so the player can track their progress in headset. When the
timer reaches zero, the round ends and the final score is the player's result.

The fruit and crate models come from a stylized asset pack (credited below),
while all of the game logic, the fruit launcher, the fruit/crate matching,
the scoring, and the timer, were scripted from scratch.

## Why it is a game
Fruit Toss fits the elements of a game we discussed in class:

- **Goal:** score as many points as possible before the timer runs out by
  matching fruit to the correct crate. This gives the player something clear
  to pursue and a way to measure success.
- **Rules:** each fruit belongs to exactly one crate, correct matches add
  points, and wrong matches subtract them. These fixed rules define what
  "winning" means and make the score meaningful.
- **Challenge:** the difficulty comes from combining several skills under time
  pressure: recognizing the randomly assigned fruit, remembering where each
  crate sits, and physically aiming with head movement in VR. The −1 penalty
  for wrong crates means the player has to weigh speed against accuracy rather
  than throwing carelessly.
- **Meaningful choice:** because the fruit is random and the crates are spread
  across the player's view, every throw asks the player to decide where to aim
  and whether a risky quick throw is worth it. Different decisions lead to
  different scores.
- **Feedback:** the score updates immediately on every hit and the countdown is
  always visible, so the player constantly sees the consequences of their
  actions and how much time is left.

Together, these give the experience a win condition, a loss condition (a low or
negative score), and a reason to play again to beat a previous score, which is
what separates it from a simple interactive toy.

## Limitations and Future Improvements
One thing I wanted to add but couldn't get working in time was a way to show
the player which fruit is about to be launched before they throw it. Right
now the fruit is chosen randomly at the moment of the throw, so the player only
finds out what they threw after it is already in the air. Previewing the next
fruit, for example, showing it held in front of the camera or as an icon on
the UI board, would let the player aim at the correct crate ahead of time and
turn the game into more of a deliberate matching challenge than a reaction one.

## Assets used
- Stylized Fruit Props [Free] by DearMousey — Unity Asset Store (fruit and
  crate models). Standard Unity Asset Store EULA.
  https://assetstore.unity.com/packages/3d/props/stylized-fruit-props-free-391728

## Deployment
Built for iOS, opened the generated Xcode project, signed with a personal Apple
ID, and deployed to a physical iPhone in a Google Cardboard viewer. See the
deployment photos in this repo.
