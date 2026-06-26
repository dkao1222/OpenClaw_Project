# Handoff: define to planning

```yaml
project_name: NeonDrift_MVP
define_page_id: 38bb9e33-8429-8123-85c7-d199267ccc1e
define_run_id: notion-NeonDrift_MVP-define-20260626162848
chain_id: raw:NeonDrift_MVP:20260626162757
output_folder: /home/node/.openclaw/workspace/382b9e3384298039b171c9b2a60ae644/NeonDrift_MVP/project/
handoff_type: define_to_planning
ready_for_planning: true
planning_stage_range: 0-12
source_documents:
  - docs/define/Defined_Request.md
  - docs/define/Project_Input_Schema.md
  - docs/define/Pipeline_Gates.md
  - docs/define/Missing_Fields_Report.md
```

## Product Experience Contract

Game Design Foundation Contract:
- Reference cards: game_system_design/GAME_DEV_BLACK_BOOK_REFERENCE.md, game_system_design/GDD_STRUCTURE_REFERENCE.md, game_system_design/GAME_MECHANICS_REFERENCE.md, game_system_design/GAME_TERMINOLOGY_REFERENCE.md, and game_quality/VISUAL_ART_REFERENCE.md must be used as bounded knowledge. Do not paste full external articles into agent context.
- GDD Structure: Planning must cover Vision Lock, Core Loop, Systems Design, Content Architecture, Player Journey, and Shipping Plan before Spec Review.
- User-Centric Reverse Deduction: Define and Planning must translate user profile -> psychological need -> mechanic/system -> production/QA evidence before development.
- MDA / Feeling-to-System Mapping: every core feature must map mechanic, dynamic, and aesthetic; QA must verify runtime evidence supports the intended feeling, not only object existence.
- Core Mechanics（核心機制）: Define and Planning must name the repeatable player actions that form the gameplay foundation, such as drift, jump, shoot, build, dodge, aim, collect, or upgrade. A game cannot proceed with only passive scoring or decorative motion.
- Game Loop（遊戲循環）: Planning must express the repeatable behavior pattern as a loop, for example explore -> collect -> build -> upgrade, start -> drift -> avoid -> score -> fail -> retry, or equivalent. Each loop step needs player intent, system response, feedback, and progression meaning.
- Systems and Tuning（系統與數值）: Planning/Spec Review must define the core systems and numbers that make the game challenging and fair, including economy/reward rules where relevant, damage or failure calculation, growth/progression curve, probability/spawn balance, difficulty ramp, and fairness/readability limits.
- Level Design（關卡設計）: Planning must define spatial layout and pacing rules that guide the player and create memorable play moments, including lanes/space, spawn rhythm, encounter pacing, tutorial/readability beats, safe windows, pressure peaks, and recovery moments.
- Development and QA must reject outputs where these four foundations remain generic, missing, or not testable.
- Moment-to-Moment Gameplay Contract: Planning must define the first 10 seconds of play as timestamped beats: player sees objective, player performs input, system creates pressure, enemy/hazard advances, feedback confirms action, reward or failure teaches the next attempt.
- Encounter / Enemy Pattern Contract: Planning must define at least three concrete enemy or hazard patterns with spawn condition, movement/approach behavior, warning/readability cue, counterplay, reward/penalty, and QA reproduction step. A static or non-approaching threat fails.
- Player Skill and Reward Contract: Planning must define how player skill changes outcome, including near miss, combo, boost/reward, score formula, risk/reward tradeoff, reset/break condition, HUD/VFX/SFX feedback, and mastery signal.
- Human Playtest Contract: QA must verify from simulator video that a human can tell what the goal is, what is dangerous, what changed after input, why failure happened, and why retry is meaningful.

Human Playability Contract:
- The player must understand what to do within 3 seconds of the first playable screen.
- The first run must show visible player motion, visible hazard motion, and at least one player input that changes risk/outcome.
- The game may not be delivered as static rectangles, invisible controls, or a passive score timer.
- Retry must restart directly into a fresh playable run within 0.3 seconds unless the defined product explicitly says otherwise.
- Retry must create a human-visible state transition: failure overlay removed, score/timer/run state reset, player or track motion resumes, and the after-retry screenshot/video must differ clearly from the game-over screenshot.
- Failure must explain the cause in human-readable language and preserve a clear retry action.

Visual Richness Contract:
- Planning must define a minimum polish bar before development: background layers, track materials, player silhouette, hazard shapes, reward/boost visuals, HUD frame, typography, icon style, motion polish, and VFX budget.
- Visual richness must improve speed, risk, reward, and retry motivation without hiding the player, hazards, HUD, or controls.
- Debug-looking placeholder blocks, single-color empty playfields, overlapping state layers, or unreadable labels fail the contract.

Interaction and State Contract:
- Main Menu, Running, Paused, Failure, RetryTransition, and Settings must have mutually exclusive visible UI rules.
- Menu UI cannot be hidden in the menu screenshot; gameplay controls cannot remain active over Failure unless intentionally listed as disabled background context.
- Left/right input, pause, settings, sound toggle, and retry must each produce visible feedback.
- RetryTransition must have observable feedback such as panel fade, countdown, track flash, player respawn pulse, or refreshed hazard layout; a probe boolean alone is insufficient evidence.

Audio Feedback Contract:
- Sound On must produce verifiable audio or runtime evidence for start, drift/input, boost/reward, collision/failure, and retry/settings feedback.
- QA cannot pass audio by checking the existence of a Sound On label only.

Evidence Contract:
- Build/QA must provide simulator screenshots and playthrough video that prove menu readability, start action, gameplay motion, input effect, failure reason, retry restart, after-retry visual delta, and sound feedback evidence.

## Next Step

Create a Planning row from this canonical defined request. Do not read unbounded raw request text.
