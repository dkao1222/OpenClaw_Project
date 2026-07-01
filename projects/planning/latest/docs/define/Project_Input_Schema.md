# Project Input Schema

## Required Fields

- Project Name
- Raw Idea（原始想法）
- Product Vision and Purpose（產品願景與目的）
- Target Audience（目標受眾）
- Core Value（核心價值）
- Platform Target
- Monetization Direction
- Compatibility Target
- Output Expectation
- Product Experience Contract
- Research Knowledge Capture Contract
- Research Source Cards
- Idea Expansion Governance
- Confirmed Requirements（已確認需求）
- Interpretation（Define 解讀）
- Expansion Candidates（可放大的候選方向）
- Recommended Direction（建議方向，但未確認）
- Open Questions（不可腦補的問題）
- Planning Input Boundary

## Size Policy

- Defined_Request.md must remain concise and downstream-readable.
- Planning handoff max 3200 characters.
- Context packs max 3000 characters.
- Formal planning docs max 8000 characters.
- Raw Idea is source context only; downstream stages must use Defined_Request.md and bounded handoffs.
- Product Experience Contract is mandatory downstream context; do not drop it during compression.
- Research Knowledge Capture Contract is mandatory downstream context when external references, web research, asset sourcing, platform policy, or product benchmarks are used.
- Downstream agents must cite source_card_id or bounded internal knowledge-base paths for research-based claims.
- Idea Expansion Governance is mandatory downstream context; compression must preserve Confirmed / Assumption / Candidate / Open Question labels.
- Expansion Candidates must remain candidates until explicit user approval or downstream decision evidence exists.

## Define Expansion Rules

Define Idea Expansion Governance:
- Define may expand a raw idea only as labeled interpretation, assumption, candidate, or recommended-not-confirmed direction.
- Define must not promote invented gameplay, genre, story, platform, monetization, visual direction, success metric, or target audience into Confirmed Requirements unless the Raw Idea explicitly states it.
- Every Expansion Candidate must include: source cue from Raw Idea, proposed product/game direction, why it fits, gameplay impact, visual/experience impact, risk, and decision status.
- Recommended Direction is allowed, but it must be labeled Recommended, not confirmed.
- Planning may use candidates for comparison and synthesis, but must keep the candidate provenance visible in planning documents and handoffs.
- If Raw Idea is too thin, Define should still provide candidate directions, but Planning must mark the selected direction as assumption-backed instead of confirmed.

## Product Experience Contract Sections

- Human Playability Contract
- Game Design Foundation Contract
- Core Mechanics（核心機制）
- Game Loop（遊戲循環）
- Systems and Tuning（系統與數值）
- Level Design（關卡設計）
- Moment-to-Moment Gameplay Contract
- Encounter / Enemy Pattern Contract
- Player Skill and Reward Contract
- Human Playtest Contract
- Visual Richness Contract
- Interaction and State Contract
- Audio Feedback Contract
- Evidence Contract

## Research Capture Contract Sections

- Research_Source_Cards.md
- Research_Synthesis.md
- Research_License_Risk_Register.md
- source_card_id
- source_url
- accessed_at
- license_or_terms
- usage_risk
- design_implication
- do_not_use_directly
