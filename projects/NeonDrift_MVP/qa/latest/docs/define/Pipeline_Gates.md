# Pipeline Gates

## Gate Rules

- Define must finish with Validation Status = Passed before Planning starts.
- Define cannot pass if invented product facts are mixed into Confirmed Requirements without being labeled as Interpretation, Assumption, Candidate, or Recommended-not-confirmed.
- Define can pass with creative expansion only when each expansion is listed under Expansion Candidates with source cue, impact, risk, and decision status.
- Planning must finish with Validation Status = Passed before Spec Review starts.
- Spec Review must finish with Validation Status = Passed before Development starts.
- Development must finish with Validation Status = Passed before Build monitoring starts.
- Build may auto-start when the licensed local Unity Editor is detected and the Build row is processing.
- QA cannot pass if Retry, audio feedback, state isolation, visual richness, or human playability evidence is missing.
- Planning cannot pass if it does not define a 10-second playability timeline, at least three enemy/encounter patterns, player skill/reward rules, and human playtest acceptance.
- Spec Review cannot pass if those planning items are not converted into implementation-ready state/input/rule/output/feedback/QA acceptance.
- Development cannot pass if runtime evidence does not prove meaningful player input, visible approaching threats, reward feedback, clear failure reason, and immediate retry.
- Any product evidence showing static gameplay, no human interaction, debug-looking visuals, overlapping states, silent Sound On, or Retry returning to the wrong state must fail and return to Development.

## Locked Decisions

- platform_target: Unity iOS first; Android/WebGL only as future scope unless explicitly requested.
- monetization_direction: Rewarded ads may be considered only after failure/retry or future revive/bonus flows; ads must not interrupt the first run or core tutorial experience.
- compatibility_target: iOS-first Unity 6000.0.77f1, local iOS simulator build, safe-area aware controls, readable on common iPhone portrait screens, performance suitable for mid-range iOS devices.
- local_unity_build: manual start, watcher monitors only
- git_publish: enabled when pipeline status is Passed

## Idea Expansion Governance

Define Idea Expansion Governance:
- Define may expand a raw idea only as labeled interpretation, assumption, candidate, or recommended-not-confirmed direction.
- Define must not promote invented gameplay, genre, story, platform, monetization, visual direction, success metric, or target audience into Confirmed Requirements unless the Raw Idea explicitly states it.
- Every Expansion Candidate must include: source cue from Raw Idea, proposed product/game direction, why it fits, gameplay impact, visual/experience impact, risk, and decision status.
- Recommended Direction is allowed, but it must be labeled Recommended, not confirmed.
- Planning may use candidates for comparison and synthesis, but must keep the candidate provenance visible in planning documents and handoffs.
- If Raw Idea is too thin, Define should still provide candidate directions, but Planning must mark the selected direction as assumption-backed instead of confirmed.

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

## Research Knowledge Capture Contract

Research Knowledge Capture Contract:
- External research is allowed only through bounded source cards. Agents must not paste full web pages, copied article text, competitor screenshots, or unverified claims into downstream context.
- Preferred owners: ux-researcher for player/product/gameplay references; evidence-collector for source-card evidence, attribution, and license risk; technical-artist for asset feasibility; product-experience-reviewer for product-experience synthesis.
- Required knowledge base reads when research is used: research_capture/ROUTING.md, research_capture/SOURCE_CARD_SCHEMA.md, research_capture/VALIDATION_GATES.md, and research_capture/LICENSE_AND_ATTRIBUTION.md.
- Required project outputs when external research is used: docs/research/Research_Source_Cards.md, docs/research/Research_Synthesis.md, docs/research/Research_License_Risk_Register.md, and status/context/research_context_pack.md.
- Each source card must include source_card_id, source_title, source_url, publisher_or_author, accessed_at, source_type, license_or_terms, usage_risk, recommended_for_stage, usable_summary, design_implication, do_not_use_directly, and open_questions.
- Planning and Spec Review must cite source card ids or bounded internal knowledge-base paths for research-based claims.
- Development may directly use external assets only when a source card marks usage_risk=low and direct_asset_use_allowed=true.
- QA must fail if a product claim, asset, platform rule, or product-experience benchmark depends on external research but no source card or license risk record exists.
